
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
            this.labelCountMov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCountFaces = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnADR = new System.Windows.Forms.Button();
            this.btnDDR = new System.Windows.Forms.Button();
            this.btnScanFace = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(4, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(19, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // onCamera
            // 
            this.onCamera.Location = new System.Drawing.Point(30, 24);
            this.onCamera.Margin = new System.Windows.Forms.Padding(2);
            this.onCamera.Name = "onCamera";
            this.onCamera.Size = new System.Drawing.Size(77, 27);
            this.onCamera.TabIndex = 2;
            this.onCamera.Text = "Activar";
            this.onCamera.UseVisualStyleBackColor = true;
            this.onCamera.Click += new System.EventHandler(this.onCamera_Click);
            // 
            // offCamera
            // 
            this.offCamera.Location = new System.Drawing.Point(30, 57);
            this.offCamera.Margin = new System.Windows.Forms.Padding(2);
            this.offCamera.Name = "offCamera";
            this.offCamera.Size = new System.Drawing.Size(77, 27);
            this.offCamera.TabIndex = 3;
            this.offCamera.Text = "Desactivar";
            this.offCamera.UseVisualStyleBackColor = true;
            this.offCamera.Click += new System.EventHandler(this.offCamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offCamera);
            this.groupBox1.Controls.Add(this.onCamera);
            this.groupBox1.Location = new System.Drawing.Point(71, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(138, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.photo);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnDetener);
            this.groupBox2.Location = new System.Drawing.Point(233, 405);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(138, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(30, 57);
            this.photo.Margin = new System.Windows.Forms.Padding(2);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(77, 27);
            this.photo.TabIndex = 3;
            this.photo.Text = "Foto";
            this.photo.UseVisualStyleBackColor = true;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(30, 24);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(77, 27);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(30, 24);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(77, 27);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Visible = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // checkBoxUmbral
            // 
            this.checkBoxUmbral.AutoSize = true;
            this.checkBoxUmbral.Location = new System.Drawing.Point(30, 32);
            this.checkBoxUmbral.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUmbral.Name = "checkBoxUmbral";
            this.checkBoxUmbral.Size = new System.Drawing.Size(59, 17);
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
            this.checkBoxRSP.Location = new System.Drawing.Point(30, 54);
            this.checkBoxRSP.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRSP.Name = "checkBoxRSP";
            this.checkBoxRSP.Size = new System.Drawing.Size(120, 17);
            this.checkBoxRSP.TabIndex = 7;
            this.checkBoxRSP.Text = "Ruido sal y pimienta";
            this.checkBoxRSP.UseVisualStyleBackColor = true;
            this.checkBoxRSP.CheckedChanged += new System.EventHandler(this.checkBoxRSP_CheckedChanged);
            // 
            // checkBoxGaussian
            // 
            this.checkBoxGaussian.AutoSize = true;
            this.checkBoxGaussian.Location = new System.Drawing.Point(30, 97);
            this.checkBoxGaussian.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGaussian.Name = "checkBoxGaussian";
            this.checkBoxGaussian.Size = new System.Drawing.Size(70, 17);
            this.checkBoxGaussian.TabIndex = 9;
            this.checkBoxGaussian.Text = "Gaussian";
            this.checkBoxGaussian.UseVisualStyleBackColor = true;
            this.checkBoxGaussian.CheckedChanged += new System.EventHandler(this.checkBoxGaussian_CheckedChanged);
            // 
            // checkBoxNegativos
            // 
            this.checkBoxNegativos.AutoSize = true;
            this.checkBoxNegativos.Location = new System.Drawing.Point(30, 76);
            this.checkBoxNegativos.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNegativos.Name = "checkBoxNegativos";
            this.checkBoxNegativos.Size = new System.Drawing.Size(74, 17);
            this.checkBoxNegativos.TabIndex = 8;
            this.checkBoxNegativos.Text = "Negativos";
            this.checkBoxNegativos.UseVisualStyleBackColor = true;
            this.checkBoxNegativos.CheckedChanged += new System.EventHandler(this.checkBoxNegativos_CheckedChanged);
            // 
            // checkBoxEG
            // 
            this.checkBoxEG.AutoSize = true;
            this.checkBoxEG.Location = new System.Drawing.Point(30, 119);
            this.checkBoxEG.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEG.Name = "checkBoxEG";
            this.checkBoxEG.Size = new System.Drawing.Size(103, 17);
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
            this.groupBox3.Location = new System.Drawing.Point(519, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(163, 202);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(44, 149);
            this.cleanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(77, 27);
            this.cleanBtn.TabIndex = 4;
            this.cleanBtn.Text = "Limpiar";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(149, 405);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(240, 44);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(707, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(490, 499);
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
            this.groupBox5.Location = new System.Drawing.Point(12, 11);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(470, 519);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dispositivos";
            // 
            // devices
            // 
            this.devices.FormattingEnabled = true;
            this.devices.Location = new System.Drawing.Point(71, 380);
            this.devices.Margin = new System.Windows.Forms.Padding(2);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(300, 21);
            this.devices.TabIndex = 6;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(5, 21);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(445, 325);
            this.videoSourcePlayer.TabIndex = 8;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.Visible = false;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // btnADM
            // 
            this.btnADM.Location = new System.Drawing.Point(6, 95);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(151, 30);
            this.btnADM.TabIndex = 14;
            this.btnADM.Text = "Activar";
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // btnDDM
            // 
            this.btnDDM.Location = new System.Drawing.Point(6, 95);
            this.btnDDM.Name = "btnDDM";
            this.btnDDM.Size = new System.Drawing.Size(151, 30);
            this.btnDDM.TabIndex = 15;
            this.btnDDM.Text = "Desactivar";
            this.btnDDM.UseVisualStyleBackColor = true;
            this.btnDDM.Visible = false;
            this.btnDDM.Click += new System.EventHandler(this.btnDDM_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.labelCountMov);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btnADM);
            this.groupBox6.Controls.Add(this.btnDDM);
            this.groupBox6.Location = new System.Drawing.Point(519, 218);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 131);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detector de movimiento";
            // 
            // labelCountMov
            // 
            this.labelCountMov.AutoSize = true;
            this.labelCountMov.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountMov.Location = new System.Drawing.Point(110, 28);
            this.labelCountMov.Name = "labelCountMov";
            this.labelCountMov.Size = new System.Drawing.Size(13, 13);
            this.labelCountMov.TabIndex = 19;
            this.labelCountMov.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Detectados:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnScanFace);
            this.groupBox7.Controls.Add(this.labelCountFaces);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.btnADR);
            this.groupBox7.Controls.Add(this.btnDDR);
            this.groupBox7.Location = new System.Drawing.Point(519, 391);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 139);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detector de rostros";
            // 
            // labelCountFaces
            // 
            this.labelCountFaces.AutoSize = true;
            this.labelCountFaces.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountFaces.Location = new System.Drawing.Point(110, 34);
            this.labelCountFaces.Name = "labelCountFaces";
            this.labelCountFaces.Size = new System.Drawing.Size(13, 13);
            this.labelCountFaces.TabIndex = 18;
            this.labelCountFaces.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detectados:";
            // 
            // btnADR
            // 
            this.btnADR.Location = new System.Drawing.Point(6, 103);
            this.btnADR.Name = "btnADR";
            this.btnADR.Size = new System.Drawing.Size(151, 30);
            this.btnADR.TabIndex = 14;
            this.btnADR.Text = "Activar";
            this.btnADR.UseVisualStyleBackColor = true;
            this.btnADR.Click += new System.EventHandler(this.btnADR_Click);
            // 
            // btnDDR
            // 
            this.btnDDR.Location = new System.Drawing.Point(6, 103);
            this.btnDDR.Name = "btnDDR";
            this.btnDDR.Size = new System.Drawing.Size(151, 30);
            this.btnDDR.TabIndex = 15;
            this.btnDDR.Text = "Desactivar";
            this.btnDDR.UseVisualStyleBackColor = true;
            this.btnDDR.Visible = false;
            this.btnDDR.Click += new System.EventHandler(this.btnDDR_Click);
            // 
            // btnScanFace
            // 
            this.btnScanFace.Location = new System.Drawing.Point(6, 52);
            this.btnScanFace.Name = "btnScanFace";
            this.btnScanFace.Size = new System.Drawing.Size(151, 30);
            this.btnScanFace.TabIndex = 19;
            this.btnScanFace.Text = "Escáner";
            this.btnScanFace.UseVisualStyleBackColor = true;
            this.btnScanFace.Click += new System.EventHandler(this.btnScanFace_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Escáner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 557);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label labelCountMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountFaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnScanFace;
    }
}

