using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
    public class Giderler
    {
        public int ID { get; set; }
        public string AY { get; set; }
        public string YIL { get; set; }
        public double ELEKTRIK { get; set; }
        public double SU { get; set; }
        public double DOGALGAZ { get; set; }
        public double INTERNET { get; set; }
        public double EKSTRA { get; set; }
        public string NOTLAR { get; set; }
    }
}
