
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
            this.checkBoxSobel = new System.Windows.Forms.CheckBox();
            this.checkBoxNegativos = new System.Windows.Forms.CheckBox();
            this.checkBoxEG = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.devices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(817, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // onCamera
            // 
            this.onCamera.Location = new System.Drawing.Point(40, 30);
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
            this.groupBox1.Location = new System.Drawing.Point(51, 401);
            this.groupBox1.Name = "groupBox1";
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
            this.groupBox2.Location = new System.Drawing.Point(267, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(40, 70);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(103, 33);
            this.photo.TabIndex = 3;
            this.photo.Text = "Foto";
            this.photo.UseVisualStyleBackColor = true;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(40, 29);
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
            this.checkBoxRSP.Name = "checkBoxRSP";
            this.checkBoxRSP.Size = new System.Drawing.Size(148, 20);
            this.checkBoxRSP.TabIndex = 7;
            this.checkBoxRSP.Text = "Ruido sal y pimienta";
            this.checkBoxRSP.UseVisualStyleBackColor = true;
            // 
            // checkBoxSobel
            // 
            this.checkBoxSobel.AutoSize = true;
            this.checkBoxSobel.Location = new System.Drawing.Point(40, 119);
            this.checkBoxSobel.Name = "checkBoxSobel";
            this.checkBoxSobel.Size = new System.Drawing.Size(63, 20);
            this.checkBoxSobel.TabIndex = 9;
            this.checkBoxSobel.Text = "Sobel";
            this.checkBoxSobel.UseVisualStyleBackColor = true;
            // 
            // checkBoxNegativos
            // 
            this.checkBoxNegativos.AutoSize = true;
            this.checkBoxNegativos.Location = new System.Drawing.Point(40, 93);
            this.checkBoxNegativos.Name = "checkBoxNegativos";
            this.checkBoxNegativos.Size = new System.Drawing.Size(89, 20);
            this.checkBoxNegativos.TabIndex = 8;
            this.checkBoxNegativos.Text = "Negativos";
            this.checkBoxNegativos.UseVisualStyleBackColor = true;
            // 
            // checkBoxEG
            // 
            this.checkBoxEG.AutoSize = true;
            this.checkBoxEG.Location = new System.Drawing.Point(40, 146);
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
            this.groupBox3.Controls.Add(this.checkBoxSobel);
            this.groupBox3.Controls.Add(this.checkBoxRSP);
            this.groupBox3.Controls.Add(this.checkBoxNegativos);
            this.groupBox3.Location = new System.Drawing.Point(558, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(59, 183);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(103, 33);
            this.cleanBtn.TabIndex = 4;
            this.cleanBtn.Text = "Limpiar";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(109, 409);
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
            this.groupBox4.Location = new System.Drawing.Point(799, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 526);
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
            this.groupBox5.Location = new System.Drawing.Point(16, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 526);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dispositivos";
            // 
            // devices
            // 
            this.devices.FormattingEnabled = true;
            this.devices.Location = new System.Drawing.Point(51, 370);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(399, 24);
            this.devices.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
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
        private System.Windows.Forms.CheckBox checkBoxSobel;
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
    }
}

