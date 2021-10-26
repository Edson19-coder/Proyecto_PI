using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
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

        
        Bitmap video;

        MotionDetector motionDetector;
        float levelMotionDetector;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

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
                pictureBox2.Image.Save(pathImages + "FotoChida.jpg", ImageFormat.Jpeg);
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

                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 1);

                foreach (Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 1))
                        {
                            graphics.DrawRectangle(pen, rectangle);
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
                pictureBox2.Image = UmbralImage((Bitmap)pictureBox2.Image, 60);
            }
            else
            {
                // Quitar filtro de la imagen
            }
        }

        private void checkBoxEG_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && checkBoxEG.Checked == true)
            {
                pictureBox2.Image = MakeGrayscale3((Bitmap)pictureBox2.Image);
            }
            else
            {
                // Quitar filtro de la imagen
            }
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageClean;
            checkBoxUmbral.Checked = false;
            checkBoxRSP.Checked = false;
            checkBoxNegativos.Checked = false;
            checkBoxSobel.Checked = false;
            checkBoxEG.Checked = false;
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
                    pictureBox2.Image = MakeGrayscale3((Bitmap)video);
                } else
                {
                    pictureBox2.Image = (Bitmap)e.Frame.Clone();
                }
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

        public Bitmap UmbralImage(Bitmap source, int umb)
        {
            // Bitmap con la imagen binaria
            Bitmap target = new Bitmap(source.Width, source.Height, source.PixelFormat);
            // Recorrer pixel de la imagen
            for (int i = 0; i < source.Width; i++)
            {
                for (int e = 0; e < source.Height; e++)
                {
                    // Color del pixel
                    Color col = source.GetPixel(i, e);
                    // Escala de grises
                    byte gray = (byte)(col.R * 0.3f + col.G * 0.59f + col.B * 0.11f);
                    // Blanco o negro
                    byte value = 0;
                    if (gray > umb)
                    {
                        value = 255;
                    }
                    // Asginar nuevo color
                    Color newColor = System.Drawing.Color.FromArgb(value, value, value);
                    target.SetPixel(i, e, newColor);

                }
            }

            return target;
        }

        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

    }
}
