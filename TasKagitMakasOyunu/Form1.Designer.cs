namespace TasKagitMakasOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblBilgisayarSkor = new Label();
            lblOyuncuSkor = new Label();
            groupBox1 = new GroupBox();
            resimMakas = new Resim();
            resimKagit = new Resim();
            resimTas = new Resim();
            resimBilgisayar = new Resim();
            resimOyuncu = new Resim();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resimMakas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resimKagit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resimTas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resimBilgisayar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resimOyuncu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Bilgisayar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 19);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 0;
            label2.Text = "Oyuncu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 183);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 0;
            label3.Text = "Skor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 183);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 0;
            label4.Text = "Skor";
            // 
            // lblBilgisayarSkor
            // 
            lblBilgisayarSkor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblBilgisayarSkor.Location = new Point(83, 221);
            lblBilgisayarSkor.Name = "lblBilgisayarSkor";
            lblBilgisayarSkor.Size = new Size(36, 19);
            lblBilgisayarSkor.TabIndex = 0;
            lblBilgisayarSkor.Text = "0";
            lblBilgisayarSkor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOyuncuSkor
            // 
            lblOyuncuSkor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblOyuncuSkor.Location = new Point(325, 221);
            lblOyuncuSkor.Name = "lblOyuncuSkor";
            lblOyuncuSkor.Size = new Size(36, 19);
            lblOyuncuSkor.TabIndex = 0;
            lblOyuncuSkor.Text = "0";
            lblOyuncuSkor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resimMakas);
            groupBox1.Controls.Add(resimKagit);
            groupBox1.Controls.Add(resimTas);
            groupBox1.Location = new Point(40, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seçiminiz";
            // 
            // resimMakas
            // 
            resimMakas.Image = (Image)resources.GetObject("resimMakas.Image");
            resimMakas.Location = new Point(266, 28);
            resimMakas.Name = "resimMakas";
            resimMakas.ResimTuru = ResimTuru.Makas;
            resimMakas.Size = new Size(110, 105);
            resimMakas.SizeMode = PictureBoxSizeMode.StretchImage;
            resimMakas.TabIndex = 2;
            resimMakas.TabStop = false;
            resimMakas.Click += resimTas_Click;
            // 
            // resimKagit
            // 
            resimKagit.Image = (Image)resources.GetObject("resimKagit.Image");
            resimKagit.Location = new Point(141, 28);
            resimKagit.Name = "resimKagit";
            resimKagit.ResimTuru = ResimTuru.Kagit;
            resimKagit.Size = new Size(110, 105);
            resimKagit.SizeMode = PictureBoxSizeMode.StretchImage;
            resimKagit.TabIndex = 1;
            resimKagit.TabStop = false;
            resimKagit.Click += resimTas_Click;
            // 
            // resimTas
            // 
            resimTas.Image = (Image)resources.GetObject("resimTas.Image");
            resimTas.Location = new Point(10, 28);
            resimTas.Name = "resimTas";
            resimTas.ResimTuru = ResimTuru.Tas;
            resimTas.Size = new Size(110, 105);
            resimTas.SizeMode = PictureBoxSizeMode.StretchImage;
            resimTas.TabIndex = 0;
            resimTas.TabStop = false;
            resimTas.Click += resimTas_Click;
            // 
            // resimBilgisayar
            // 
            resimBilgisayar.Location = new Point(53, 62);
            resimBilgisayar.Name = "resimBilgisayar";
            resimBilgisayar.ResimTuru = ResimTuru.Bos;
            resimBilgisayar.Size = new Size(110, 105);
            resimBilgisayar.SizeMode = PictureBoxSizeMode.StretchImage;
            resimBilgisayar.TabIndex = 2;
            resimBilgisayar.TabStop = false;
            // 
            // resimOyuncu
            // 
            resimOyuncu.Location = new Point(296, 62);
            resimOyuncu.Name = "resimOyuncu";
            resimOyuncu.ResimTuru = ResimTuru.Bos;
            resimOyuncu.Size = new Size(110, 105);
            resimOyuncu.SizeMode = PictureBoxSizeMode.StretchImage;
            resimOyuncu.TabIndex = 3;
            resimOyuncu.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 443);
            Controls.Add(resimOyuncu);
            Controls.Add(resimBilgisayar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lblOyuncuSkor);
            Controls.Add(label4);
            Controls.Add(lblBilgisayarSkor);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resimMakas).EndInit();
            ((System.ComponentModel.ISupportInitialize)resimKagit).EndInit();
            ((System.ComponentModel.ISupportInitialize)resimTas).EndInit();
            ((System.ComponentModel.ISupportInitialize)resimBilgisayar).EndInit();
            ((System.ComponentModel.ISupportInitialize)resimOyuncu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblBilgisayarSkor;
        private Label lblOyuncuSkor;
        private GroupBox groupBox1;
        private Resim resimBilgisayar;
        private Resim resimMakas;
        private Resim resimKagit;
        private Resim resimTas;
        private Resim resimOyuncu;
    }
}
