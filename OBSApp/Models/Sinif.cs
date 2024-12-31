using System;
namespace OBSApp.Models
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
