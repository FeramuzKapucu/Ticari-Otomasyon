using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari;

namespace TicariOtomasyon
{
    public partial class StoklarFormu : Form
    {
        public StoklarFormu()
        {
            InitializeComponent();
        }

        private void StoklarFormu_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Tur,SUM(ADET) as 'SAYI'  from Urunler as U join Urun_Turu as T on U.UrunAd=T.ID  Group BY tur", Tools.Baglanti);
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Charta Stok Mikt5arlarını Girme

            SqlCommand cmd = new SqlCommand("Select Tur,SUM(ADET) as 'SAYI'  from Urunler as U join Urun_Turu as T on U.UrunAd=T.ID  Group BY tur", Tools.Baglanti);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1]));
            }
            cmd.Connection.Close();


            SqlCommand cmd2 = new SqlCommand("Select IL,COUNT(*)   from Firmalar Group BY IL", Tools.Baglanti);
            cmd2.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), Convert.ToInt32(dr2[1]));
            }
            cmd2.Connection.Close();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            StokdetayFormu detay = new StokdetayFormu();
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(row!= null)
            {
                detay.ad = row["Tur"].ToString();
            }
            detay.Show();
        }
    }
}
