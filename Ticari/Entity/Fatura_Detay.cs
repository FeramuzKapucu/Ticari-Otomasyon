using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
   public class Fatura_Detay
    {
        public int FATURADETAYID { get; set; }
        public string URUNAD { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public double ALIS { get; set; }
        public int MIKTAR { get; set; }
        public double FIYAT { get; set; }
        public double TUTAR { get; set; }
        public int FATURAID { get; set; }
        public DateTime TARIH { get; set; }
    }
}
