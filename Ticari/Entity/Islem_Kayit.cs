using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari.Entity
{
   public class Islem_Kayit
    {
        public int IslemID { get; set; }
        public int NesneID { get; set; }
        public string IslemPersonel { get; set; }
        public IslemTipi ISLEMTIPI { get; set; }
        public IslemForm IslemForm { get; set; }
        public DateTime ISLEMTARIH { get; set; }
    }
    public enum IslemTipi
    {
        Adding = 1,
        Deleting = 2,
        Updating = 3
    };

    public enum IslemForm
    {
        Banka = 1,
        Fatura = 2,
        Firma = 3,
        Gider = 4,
        Musteri = 5,
        Not = 6,
        Personel = 7,
        Ürün=8
    };
}
