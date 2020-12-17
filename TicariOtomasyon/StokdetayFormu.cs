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
    public partial class StokdetayFormu : Form
    {
        public StokdetayFormu()
        {
            InitializeComponent();
        }
        public string ad;

        private void StokdetayFormu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Tur,Marka,model,Yıl,Adet,AlısFIYAT,SATISFIYAT,DETAY from Urunler as U join Urun_Turu as T on U.UrunAd=T.ID   where tur=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", ad);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
