using OBSApp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OBSApp
{
    public partial class DersSecimForm : Form
    {
        private Ogrenci _ogrenci;

        public DersSecimForm(Ogrenci ogrenci)
        {
            InitializeComponent();
            _ogrenci = ogrenci;
            LoadDersler();
            DisplayOgrenciBilgileri();
        }

        private void DisplayOgrenciBilgileri()
        {
            if (_ogrenci != null)
            {
                
                lblOgrenciBilgileri.Text = $"Ad: {_ogrenci.Ad}, Soyad: {_ogrenci.Soyad}, " +
                                           $"Numara: {_ogrenci.Numara}, Sınıf: {_ogrenci.Sinif.SinifAd}";
            }
            else
            {
                MessageBox.Show("Öğrenci bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadDersler()
        {
            using (var ctx = new AppDbContext())
            {
                var dersler = ctx.Dersler
                    .Select(d => new
                    {
                        d.DersId,
                        d.DersKod,
                        d.DersAd
                    })
                    .ToList();

                dgvDersler.DataSource = dersler;

                
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Seç",
                    Name = "DersSecim"
                };
                dgvDersler.Columns.Insert(0, checkColumn);
            }

            dgvDersler.Columns["DersId"].Visible = false;
        }

        private void btnDersleriKaydet_Click(object sender, EventArgs e)
        {
           
                bool derslerEklendi = false; 

                try
                {
                    using (var ctx = new AppDbContext())
                    {
                        foreach (DataGridViewRow row in dgvDersler.Rows)
                        {
                            
                            if (Convert.ToBoolean(row.Cells["DersSecim"].Value) == true)
                            {
                                int dersId = Convert.ToInt32(row.Cells["DersId"].Value);

                              
                                bool dersZatenSecilmis = ctx.OgrenciDersler.Any(od => od.OgrenciId == _ogrenci.OgrenciId && od.DersId == dersId);

                                if (dersZatenSecilmis)
                                {
                                    MessageBox.Show($"Bu ders zaten seçilmiş: {row.Cells["DersAd"].Value}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    continue;
                                }

                               
                                var ogrenciDers = new OgrenciDers
                                {
                                    OgrenciId = _ogrenci.OgrenciId,
                                    DersId = dersId
                                };

                                ctx.OgrenciDersler.Add(ogrenciDers);
                                derslerEklendi = true; 
                            }
                        }

                        
                        if (derslerEklendi)
                        {
                            ctx.SaveChanges();
                            MessageBox.Show("Dersler başarıyla kaydedildi!");
                        }
                        else
                        {
                            MessageBox.Show("Seçilen derslerde değişiklik yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        

        }
    }
}
