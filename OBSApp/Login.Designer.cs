namespace OBSApp
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
            groupBox1 = new GroupBox();
            txtAd = new TextBox();
            cmbSiniflar = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            lbl_Sınıf = new Label();
            lbl_Numara = new Label();
            lbl_Soyad = new Label();
            lbl_Ad = new Label();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnBul = new Button();
            btnDers = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(cmbSiniflar);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(lbl_Sınıf);
            groupBox1.Controls.Add(lbl_Numara);
            groupBox1.Controls.Add(lbl_Soyad);
            groupBox1.Controls.Add(lbl_Ad);
            groupBox1.Location = new Point(24, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ogrenci Ekleme";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(101, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 23);
            txtAd.TabIndex = 0;
            // 
            // cmbSiniflar
            // 
            cmbSiniflar.FormattingEnabled = true;
            cmbSiniflar.Location = new Point(101, 133);
            cmbSiniflar.Name = "cmbSiniflar";
            cmbSiniflar.Size = new Size(121, 23);
            cmbSiniflar.TabIndex = 3;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(101, 101);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(121, 23);
            txtNumara.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(101, 72);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(121, 23);
            txtSoyad.TabIndex = 1;
            // 
            // lbl_Sınıf
            // 
            lbl_Sınıf.AutoSize = true;
            lbl_Sınıf.Location = new Point(26, 136);
            lbl_Sınıf.Name = "lbl_Sınıf";
            lbl_Sınıf.Size = new Size(69, 15);
            lbl_Sınıf.TabIndex = 3;
            lbl_Sınıf.Text = "Sınıf Seçiniz";
            // 
            // lbl_Numara
            // 
            lbl_Numara.AutoSize = true;
            lbl_Numara.Location = new Point(45, 104);
            lbl_Numara.Name = "lbl_Numara";
            lbl_Numara.Size = new Size(50, 15);
            lbl_Numara.TabIndex = 2;
            lbl_Numara.Text = "Numara";
            // 
            // lbl_Soyad
            // 
            lbl_Soyad.AutoSize = true;
            lbl_Soyad.Location = new Point(56, 75);
            lbl_Soyad.Name = "lbl_Soyad";
            lbl_Soyad.Size = new Size(39, 15);
            lbl_Soyad.TabIndex = 1;
            lbl_Soyad.Text = "Soyad";
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(73, 43);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(22, 15);
            lbl_Ad.TabIndex = 0;
            lbl_Ad.Text = "Ad";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(24, 253);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(95, 33);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(125, 253);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(121, 33);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(252, 253);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(95, 33);
            btnBul.TabIndex = 5;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDers
            // 
            btnDers.Location = new Point(125, 292);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(121, 33);
            btnDers.TabIndex = 7;
            btnDers.Text = "Ders Seçimi";
            btnDers.UseVisualStyleBackColor = true;
            btnDers.Click += btnDers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 332);
            Controls.Add(btnDers);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox textBox1;
        private Label lbl_Sınıf;
        private Label lbl_Numara;
        private Label lbl_Soyad;
        private Label lbl_Ad;
        private ComboBox cmbSiniflar;
        private TextBox txtAd;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnDers;
    }
}