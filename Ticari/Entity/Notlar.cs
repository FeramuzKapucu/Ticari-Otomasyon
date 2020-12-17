using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
    public class Notlar
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime SAAT { get; set; }
        public string BASLIK { get; set; }
        public string DETAY { get; set; }
        public int OLUSTURAN { get; set; }
        public string KIME { get; set; }
    }
}
