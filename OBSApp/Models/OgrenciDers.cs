﻿using System;

namespace OBSApp.Models
{
    public class OgrenciDers
    {
        public int DersId { get; set; }
        public int OgrenciId { get; set; }

        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }

}

