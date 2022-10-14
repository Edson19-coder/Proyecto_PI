using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Imaging.Filters;

using AForge.Video;
using AForge.Video.DirectShow;

using AForge.Video.FFMPEG;

using AForge.Vision.Motion;

using Emgu.CV;
using Emgu.CV.Structure;

namespace PIA_ProcesamientoDeImagenes
{
    public partial class Form1 : Form
    {
        private string pathImages = @"D:\Codigo\PI\ProcesamientoDeImagenes\ProcesamientoDeImagenes\Imagenes\";
        private bool thereAreDevices;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice webCam;
        private Bitmap imageClean;
        String countFaces;
        String countMov;


        Bitmap video;

        MotionDetector motionDetector;
        float levelMotionDetector;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        ColorMatrix grayScaleMatrix = new ColorMatrix(
               new float[][]
               {
                new float[] {.3f, .3f, .3f, 0, 0},
                new float[] {.59f, .59f, .59f, 0, 0},
                new float[] {.11f, .11f, .11f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
               });

        ColorMatrix negativeColorMatrix = new ColorMatrix(
            new float[][]
            {
                new float[] {-1f, 0f, 0f, 0, 0},
                new float[] {0f, -1f, 0f, 0, 0},
                new float[] {0f, 0f, -1f, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 1, 1, 1, 0, 1}
            });

        ColorMatrix umbralMatrix = new ColorMatrix(
            new float[][]
            {
                new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {-1, -1, -1, 0, 1}
            });
        private SaveFileDialog pathSave;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            levelMotionDetector = 0;
            LoadDevices();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCamera();
            pictureBox1.Image = null;
        }

        private void onCamera_Click(object sender, EventArgs e)
        {
            CloseCamera();
            int cameraIndex = devices.SelectedIndex;
            string nameDevices = myDevices[cameraIndex].MonikerString;
            webCam = new VideoCaptureDevice(nameDevices);
            webCam.NewFrame += new AForge.Video.NewFrameEventHandler(Capture);
            webCam.Start();
        }


        private void offCamera_Click(object sender, EventArgs e)
        {
            CloseCamera();
            pictureBox1.Image = null;
        }

        private void photo_Click(object sender, EventArgs e)
        {
            if (webCam != null && webCam.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
                imageClean = (Bitmap)pictureBox2.Image;
            }
        }
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (webCam != null && webCam.IsRunning)
            {
                btnGrabar.Visible = false;
                btnDetener.Visible = true;

                webCam.NewFrame += new AForge.Video.NewFrameEventHandler(Capture2);

            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnDetener.Visible = false;
            btnGrabar.Visible = true;
            pictureBox2.Image = null;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image != null)
            {
                pathSave = new SaveFileDialog();
                pathSave.Filter = "jpg files(*jpg)|*.jpg";
                if(pathSave.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(pathSave.FileName);
                }
            }
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            btnADM.Visible = false;
            btnDDM.Visible = true;

            videoSourcePlayer.Visible = true;

            videoSourcePlayer.VideoSource = webCam;
            videoSourcePlayer.Start();
        }

        private void btnDDM_Click(object sender, EventArgs e)
        {
            btnADM.Visible = true;
            btnDDM.Visible = false;

            videoSourcePlayer.Visible = false;

            videoSourcePlayer.Stop();
            webCam.Start();
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            levelMotionDetector = motionDetector.ProcessFrame(image);
        }

        private void btnADR_Click(object sender, EventArgs e)
        {
            btnADR.Visible = false;
            btnDDR.Visible = true;
            webCam.NewFrame += FaceDetection;
        }

        private void FaceDetection(object sender, NewFrameEventArgs eventArgs)
        {
            if (btnDDR.Visible)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();

                Rectangle[] detectedFaces = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

                countFaces = detectedFaces.Length.ToString();

                SolidBrush solidBrush = new SolidBrush(Color.Red);
                Font font = new Font("Arial", 30.0f);

                int i = 0;

                foreach (Rectangle face in detectedFaces)
                {
                    i++;
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 6))
                        {
                            graphics.DrawRectangle(pen, face);
                            graphics.DrawString("Persona" + i, font, solidBrush, face.Location);
                        }
                    }
                }
                pictureBox1.Image = bitmap;
            }
        }

        private void btnDDR_Click(object sender, EventArgs e)
        {
            btnADR.Visible = true;
            btnDDR.Visible = false;
        }

        /////////////////////   Filtros    ///////////////////////// 

        private void checkBoxUmbral_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxUmbral.Checked == true && btnDetener.Visible == false)
            {
                pictureBox2.Image = ApplyColorMatrix((Bitmap)pictureBox2.Image, umbralMatrix);
                checkBoxUmbral.Enabled = false;
            }
        }

        private void checkBoxEG_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxEG.Checked == true && btnDetener.Visible == false)
            {
                pictureBox2.Image = ApplyColorMatrix((Bitmap)pictureBox2.Image, grayScaleMatrix);
                checkBoxEG.Enabled = false;
            }
        }

        private void checkBoxNegativos_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxNegativos.Checked == true && btnDetener.Visible == false)
            {
                pictureBox2.Image = ApplyColorMatrix((Bitmap)pictureBox2.Image, negativeColorMatrix);
                checkBoxNegativos.Enabled = false;
            }
        }

        private void checkBoxRSP_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxRSP.Checked == true && btnDetener.Visible == false)
            {
                pictureBox2.Image = ImpulseNoise((Bitmap)pictureBox2.Image);
                checkBoxRSP.Enabled = false;
            }
        }

        private void checkBoxGaussian_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxGaussian.Checked == true && btnDetener.Visible == false)
            {
                pictureBox2.Image = GaussianNoise((Bitmap)pictureBox2.Image);
                checkBoxGaussian.Enabled = false;
            }
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageClean;
            checkBoxUmbral.Checked = false;
            checkBoxRSP.Checked = false;
            checkBoxNegativos.Checked = false;
            checkBoxGaussian.Checked = false;
            checkBoxEG.Checked = false;

            checkBoxUmbral.Enabled = true;
            checkBoxRSP.Enabled = true;
            checkBoxNegativos.Enabled = true;
            checkBoxGaussian.Enabled = true;
            checkBoxEG.Enabled = true;
        }

        /////////////////////   Funciones    ///////////////////////// 

        public void LoadDevices()
        {
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (myDevices.Count > 0)
            {
                thereAreDevices = true;

                for (int i = 0; i < myDevices.Count; i++)
                {
                    devices.Items.Add(myDevices[i].Name.ToString());
                    devices.Text = myDevices[0].Name.ToString();
                }
            }
            else
                thereAreDevices = false;
        }

        private void Capture(object sender, NewFrameEventArgs e)
        {

            Bitmap image = (Bitmap)e.Frame.Clone();

            pictureBox1.Image = image;
        }

        private void Capture2(object sender, NewFrameEventArgs e)
        {

            if(btnDetener.Visible)
            {
                video = (Bitmap)e.Frame.Clone();

                if(checkBoxEG.Checked == true)
                {
                    video = ApplyColorMatrix((Bitmap)video, grayScaleMatrix);
                } 
                if(checkBoxNegativos.Checked == true)
                {
                    video = ApplyColorMatrix((Bitmap)video, negativeColorMatrix);
                }
                if (checkBoxUmbral.Checked == true)
                {
                    video = ApplyColorMatrix((Bitmap)video, umbralMatrix);
                }
                if(checkBoxRSP.Checked == true)
                {
                    video = ImpulseNoise((Bitmap)video);
                }
                if(checkBoxGaussian.Checked == true)
                {
                    video = GaussianNoise((Bitmap)video);
                }

                pictureBox2.Image = video;
            }
        }

        private void CloseCamera()
        {
            if (webCam != null && webCam.IsRunning)
            {
                webCam.SignalToStop();
                webCam = null;
            }
        }

        /////////////////////   Filtros    ///////////////////////// 

        //Aplicación de matriz
        private static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        {
            Bitmap bmp32BppSource = GetArgbCopy(sourceImage);
            Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp32BppSource, new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
                                    0, 0, bmp32BppSource.Width, bmp32BppSource.Height, GraphicsUnit.Pixel, bmpAttributes);
            }
            bmp32BppSource.Dispose();
            return bmp32BppDest;
        }

        //Se convierte el formato de la pagina ya que tal cual no se puede aplicar el filtro.
        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }
            return bmpNew;
        }

        //Sal y pimienta
        public static Bitmap ImpulseNoise(Bitmap image)
        {

            //Obtenemos las dimesiaones de la imagen.
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            //Para crear puntos randoms
            Random rnd = new Random();

            int noise_chance = 10;

            //Aplicamos pixel por pixel
            for (int i = 0; i < bytes; i += 3)
            {
                int max = (int)(1000 / noise_chance);
                int tmp = rnd.Next(max + 1);
                for (int j = 0; j < 3; j++)
                {
                    if (tmp == 0 || tmp == max)
                    {
                        int sorp = tmp / max;
                        result[i + j] = (byte)(sorp * 255);
                    }
                    else
                    {
                        result[i + j] = buffer[i + j];
                    }
                }
            }

            Bitmap result_image = new Bitmap(w, h);

            //Bloqueamos el acceso de bits para conversión al formato deseado
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }

        //Gaussian
        public static Bitmap GaussianNoise(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            byte[] noise = new byte[bytes];
            double[] gaussian = new double[256];
            int std = 20;
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                gaussian[i] = (double)((1 / (Math.Sqrt(2 * Math.PI) * std)) * Math.Exp(-Math.Pow(i, 2) / (2 * Math.Pow(std, 2))));
                sum += gaussian[i];
            }

            for (int i = 0; i < 256; i++)
            {
                gaussian[i] /= sum;
                gaussian[i] *= bytes;
                gaussian[i] = (int)Math.Floor(gaussian[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)gaussian[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)gaussian[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)(buffer[i] + noise[i]);
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);
            return result_image;
        }

        private void btnScanFace_Click(object sender, EventArgs e)
        {
            if(countFaces != null && btnDDR.Visible == true)
            {
                labelCountFaces.Text = countFaces;
            }
            else
            {
                labelCountFaces.Text = "0";
            }
        }
    }
}
