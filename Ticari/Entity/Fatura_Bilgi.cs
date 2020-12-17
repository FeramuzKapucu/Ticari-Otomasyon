using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
   public class Fatura_Bilgi
    {
        public int FATURABILGIID { get; set; }
        public char SERI { get; set; }
        public string SIRANO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime SAAT { get; set; }
        public string VERGIDAIRE { get; set; }
        public string ALICI { get; set; }
        public string TESLIMEDEN { get; set; }
        public string TESLIMALAN { get; set; }
        public bool SILINDI { get; set; }
    }
}
