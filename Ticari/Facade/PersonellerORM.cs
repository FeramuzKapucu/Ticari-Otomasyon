using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entity;

namespace Ticari.Facade
{
    public class PersonellerORM : ORMBase<Personeller>
    {
        // İşlemleri Yapan Aktif Personel Belirli Olsun Diye Kullanılacak
        public static Personeller AktifPersonel;

        public Personeller Girisyap(Personeller p)
        //İçerisinde Personeller tipinden değer alan bir fonskiyon sql de select yapıyor eğer gönderilen veri tabanında kayıtlı değilse null kayıtlı ise aktif admin olarak o değer döndürülüyor. 
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personel_Giris", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@TC", p.TC);
            adp.SelectCommand.Parameters.AddWithValue("@SIFRE", p.SIFRE);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            Personeller aktif = new Personeller();
            foreach (DataRow dr in dt.Rows)
            {
                aktif.ID = (int)dr["ID"];
                aktif.AD = dr["AD"].ToString();
                aktif.SOYAD = dr["SOYAD"].ToString();
                aktif.TC = dr["TC"].ToString();
                aktif.SIFRE = dr["SIFRE"].ToString();
            }

            return aktif;
        }
    }
}
