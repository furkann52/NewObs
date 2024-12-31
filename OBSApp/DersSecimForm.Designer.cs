namespace OBSApp
{
    partial class DersSecimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOgrenciBilgileri = new Label();
            dgvDersler = new DataGridView();
            lblDersler = new Label();
            btnDersleriKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(17, 82);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(38, 15);
            lblOgrenciBilgileri.TabIndex = 0;
            lblOgrenciBilgileri.Text = "label1";
            // 
            // dgvDersler
            // 
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(12, 159);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowTemplate.Height = 25;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(736, 200);
            dgvDersler.TabIndex = 1;
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(12, 141);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(43, 15);
            lblDersler.TabIndex = 2;
            lblDersler.Text = "Dersler";
            // 
            // btnDersleriKaydet
            // 
            btnDersleriKaydet.Location = new Point(239, 387);
            btnDersleriKaydet.Name = "btnDersleriKaydet";
            btnDersleriKaydet.Size = new Size(218, 37);
            btnDersleriKaydet.TabIndex = 3;
            btnDersleriKaydet.Text = "Seçilen Dersleri Kaydet";
            btnDersleriKaydet.UseVisualStyleBackColor = true;
            btnDersleriKaydet.Click += btnDersleriKaydet_Click;
            // 
            // DersSecimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDersleriKaydet);
            Controls.Add(lblDersler);
            Controls.Add(dgvDersler);
            Controls.Add(lblOgrenciBilgileri);
            Name = "DersSecimForm";
            Text = "DersSecimForm";
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgrenciBilgileri;
        private DataGridView dgvDersler;
        private Label lblDersler;
        private Button btnDersleriKaydet;
    }
}