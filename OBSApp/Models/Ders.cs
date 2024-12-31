using System;

namespace OBSApp.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersKod { get; set; }
        public string DersAd { get; set; }

        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}

