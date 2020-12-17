using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
    public class Urunler
    {
        public int ID { get; set; }
        public int URUNAD { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public string YIL { get; set; }
        public int ADET { get; set; }
        public double ALISFIYAT { get; set; }
        public double SATISFIYAT { get; set; }
        public string DETAY { get; set; }
    }
}
