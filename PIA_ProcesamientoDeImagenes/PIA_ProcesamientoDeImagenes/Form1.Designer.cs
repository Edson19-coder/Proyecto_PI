
namespace PIA_ProcesamientoDeImagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onCamera = new System.Windows.Forms.Button();
            this.offCamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.photo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.checkBoxUmbral = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxRSP = new System.Windows.Forms.CheckBox();
            this.checkBoxGaussian = new System.Windows.Forms.CheckBox();
            this.checkBoxNegativos = new System.Windows.Forms.CheckBox();
            this.checkBoxEG = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.devices = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnADM = new System.Windows.Forms.Button();
            this.btnDDM = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnADR = new System.Windows.Forms.Button();
            this.btnDDR = new System.Windows.Forms.Button();
            this.btnScanFace = new System.Windows.Forms.Button();
            this.labelCountFaces = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(25, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(609, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // onCamera
            // 
            this.onCamera.Location = new System.Drawing.Point(40, 30);
            this.onCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onCamera.Name = "onCamera";
            this.onCamera.Size = new System.Drawing.Size(103, 33);
            this.onCamera.TabIndex = 2;
            this.onCamera.Text = "Activar";
            this.onCamera.UseVisualStyleBackColor = true;
            this.onCamera.Click += new System.EventHandler(this.onCamera_Click);
            // 
            // offCamera
            // 
            this.offCamera.Location = new System.Drawing.Point(40, 70);
            this.offCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offCamera.Name = "offCamera";
            this.offCamera.Size = new System.Drawing.Size(103, 33);
            this.offCamera.TabIndex = 3;
            this.offCamera.Text = "Desactivar";
            this.offCamera.UseVisualStyleBackColor = true;
            this.offCamera.Click += new System.EventHandler(this.offCamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offCamera);
            this.groupBox1.Controls.Add(this.onCamera);
            this.groupBox1.Location = new System.Drawing.Point(95, 498);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.photo);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnDetener);
            this.groupBox2.Location = new System.Drawing.Point(311, 498);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(184, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(40, 70);
            this.photo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(103, 33);
            this.photo.TabIndex = 3;
            this.photo.Text = "Foto";
            this.photo.UseVisualStyleBackColor = true;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(40, 30);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(103, 33);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(40, 30);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(103, 33);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Visible = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // checkBoxUmbral
            // 
            this.checkBoxUmbral.AutoSize = true;
            this.checkBoxUmbral.Location = new System.Drawing.Point(40, 39);
            this.checkBoxUmbral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUmbral.Name = "checkBoxUmbral";
            this.checkBoxUmbral.Size = new System.Drawing.Size(71, 20);
            this.checkBoxUmbral.TabIndex = 6;
            this.checkBoxUmbral.Text = "Umbral";
            this.checkBoxUmbral.UseVisualStyleBackColor = true;
            this.checkBoxUmbral.Click += new System.EventHandler(this.checkBoxUmbral_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(622, 233);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 19);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Filtro 1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxRSP
            // 
            this.checkBoxRSP.AutoSize = true;
            this.checkBoxRSP.Location = new System.Drawing.Point(40, 66);
            this.checkBoxRSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRSP.Name = "checkBoxRSP";
            this.checkBoxRSP.Size = new System.Drawing.Size(148, 20);
            this.checkBoxRSP.TabIndex = 7;
            this.checkBoxRSP.Text = "Ruido sal y pimienta";
            this.checkBoxRSP.UseVisualStyleBackColor = true;
            this.checkBoxRSP.CheckedChanged += new System.EventHandler(this.checkBoxRSP_CheckedChanged);
            // 
            // checkBoxGaussian
            // 
            this.checkBoxGaussian.AutoSize = true;
            this.checkBoxGaussian.Location = new System.Drawing.Point(40, 119);
            this.checkBoxGaussian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGaussian.Name = "checkBoxGaussian";
            this.checkBoxGaussian.Size = new System.Drawing.Size(84, 20);
            this.checkBoxGaussian.TabIndex = 9;
            this.checkBoxGaussian.Text = "Gaussian";
            this.checkBoxGaussian.UseVisualStyleBackColor = true;
            this.checkBoxGaussian.CheckedChanged += new System.EventHandler(this.checkBoxGaussian_CheckedChanged);
            // 
            // checkBoxNegativos
            // 
            this.checkBoxNegativos.AutoSize = true;
            this.checkBoxNegativos.Location = new System.Drawing.Point(40, 94);
            this.checkBoxNegativos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNegativos.Name = "checkBoxNegativos";
            this.checkBoxNegativos.Size = new System.Drawing.Size(89, 20);
            this.checkBoxNegativos.TabIndex = 8;
            this.checkBoxNegativos.Text = "Negativos";
            this.checkBoxNegativos.UseVisualStyleBackColor = true;
            this.checkBoxNegativos.CheckedChanged += new System.EventHandler(this.checkBoxNegativos_CheckedChanged);
            // 
            // checkBoxEG
            // 
            this.checkBoxEG.AutoSize = true;
            this.checkBoxEG.Location = new System.Drawing.Point(40, 146);
            this.checkBoxEG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEG.Name = "checkBoxEG";
            this.checkBoxEG.Size = new System.Drawing.Size(128, 20);
            this.checkBoxEG.TabIndex = 10;
            this.checkBoxEG.Text = "Escala de grises";
            this.checkBoxEG.UseVisualStyleBackColor = true;
            this.checkBoxEG.Click += new System.EventHandler(this.checkBoxEG_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cleanBtn);
            this.groupBox3.Controls.Add(this.checkBoxEG);
            this.groupBox3.Controls.Add(this.checkBoxUmbral);
            this.groupBox3.Controls.Add(this.checkBoxGaussian);
            this.groupBox3.Controls.Add(this.checkBoxRSP);
            this.groupBox3.Controls.Add(this.checkBoxNegativos);
            this.groupBox3.Location = new System.Drawing.Point(692, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(217, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(59, 183);
            this.cleanBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(103, 33);
            this.cleanBtn.TabIndex = 4;
            this.cleanBtn.Text = "Limpiar";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(199, 498);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(320, 54);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(943, 38);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(653, 614);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.devices);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.videoSourcePlayer);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(16, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(627, 639);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dispositivos";
            // 
            // devices
            // 
            this.devices.FormattingEnabled = true;
            this.devices.Location = new System.Drawing.Point(95, 468);
            this.devices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(399, 24);
            this.devices.TabIndex = 6;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(7, 26);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(593, 400);
            this.videoSourcePlayer.TabIndex = 8;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.Visible = false;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // btnADM
            // 
            this.btnADM.Location = new System.Drawing.Point(8, 36);
            this.btnADM.Margin = new System.Windows.Forms.Padding(4);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(201, 37);
            this.btnADM.TabIndex = 14;
            this.btnADM.Text = "Activar";
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // btnDDM
            // 
            this.btnDDM.Location = new System.Drawing.Point(8, 36);
            this.btnDDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnDDM.Name = "btnDDM";
            this.btnDDM.Size = new System.Drawing.Size(201, 37);
            this.btnDDM.TabIndex = 15;
            this.btnDDM.Text = "Desactivar";
            this.btnDDM.UseVisualStyleBackColor = true;
            this.btnDDM.Visible = false;
            this.btnDDM.Click += new System.EventHandler(this.btnDDM_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnADM);
            this.groupBox6.Controls.Add(this.btnDDM);
            this.groupBox6.Location = new System.Drawing.Point(692, 422);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(217, 85);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detector de movimiento";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnADR);
            this.groupBox7.Controls.Add(this.btnDDR);
            this.groupBox7.Location = new System.Drawing.Point(692, 549);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(217, 81);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detector de rostros";
            // 
            // btnADR
            // 
            this.btnADR.Location = new System.Drawing.Point(8, 31);
            this.btnADR.Margin = new System.Windows.Forms.Padding(4);
            this.btnADR.Name = "btnADR";
            this.btnADR.Size = new System.Drawing.Size(201, 37);
            this.btnADR.TabIndex = 14;
            this.btnADR.Text = "Activar";
            this.btnADR.UseVisualStyleBackColor = true;
            this.btnADR.Click += new System.EventHandler(this.btnADR_Click);
            // 
            // btnDDR
            // 
            this.btnDDR.Location = new System.Drawing.Point(8, 31);
            this.btnDDR.Margin = new System.Windows.Forms.Padding(4);
            this.btnDDR.Name = "btnDDR";
            this.btnDDR.Size = new System.Drawing.Size(201, 37);
            this.btnDDR.TabIndex = 15;
            this.btnDDR.Text = "Desactivar";
            this.btnDDR.UseVisualStyleBackColor = true;
            this.btnDDR.Visible = false;
            this.btnDDR.Click += new System.EventHandler(this.btnDDR_Click);
            // 
            // btnScanFace
            // 
            this.btnScanFace.Location = new System.Drawing.Point(700, 347);
            this.btnScanFace.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanFace.Name = "btnScanFace";
            this.btnScanFace.Size = new System.Drawing.Size(201, 37);
            this.btnScanFace.TabIndex = 19;
            this.btnScanFace.Text = "Escáner";
            this.btnScanFace.UseVisualStyleBackColor = true;
            this.btnScanFace.Click += new System.EventHandler(this.btnScanFace_Click);
            // 
            // labelCountFaces
            // 
            this.labelCountFaces.AutoSize = true;
            this.labelCountFaces.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountFaces.Location = new System.Drawing.Point(836, 298);
            this.labelCountFaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountFaces.Name = "labelCountFaces";
            this.labelCountFaces.Size = new System.Drawing.Size(15, 16);
            this.labelCountFaces.TabIndex = 18;
            this.labelCountFaces.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detectados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 686);
            this.Controls.Add(this.btnScanFace);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.labelCountFaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Procesamiento de Imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button onCamera;
        private System.Windows.Forms.Button offCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button photo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.CheckBox checkBoxUmbral;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxRSP;
        private System.Windows.Forms.CheckBox checkBoxGaussian;
        private System.Windows.Forms.CheckBox checkBoxNegativos;
        private System.Windows.Forms.CheckBox checkBoxEG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox devices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnDDM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnADR;
        private System.Windows.Forms.Button btnDDR;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Label labelCountFaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScanFace;
    }
}

