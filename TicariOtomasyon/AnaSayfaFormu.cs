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
using System.Xml;
using Ticari;

namespace TicariOtomasyon
{
    public partial class AnaSayfaFormu : Form
    {
        public AnaSayfaFormu()
        {
            InitializeComponent();
        }
        //Azalan Stokları Grid e çekme
        private void StokCekme()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Tur,Marka,Model,Adet from Urunler as U join Urun_Turu as T on U.UrunAd=T.ID  where (Adet)<=20 order by Tur", Tools.Baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grdstok.DataSource = dt;
        }

        //Notlatrı Çekme
        private void NotCek()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select top 5 TARIH,BASLIK from NOTLAR order by ID Desc", Tools.Baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grdnotlar.DataSource = dt;
        }

        //Fihrist
        private void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select AD,TELEFON1 from Firmalar", Tools.Baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grdfihrist.DataSource = dt;
        }

        //Son 10 Firma Satışı
        private void HareketCek()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select top 10 * from Fatura_Detay  order by FATURADETAYID desc", Tools.Baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grdhareket.DataSource = dt;
        }


        private void AnaSayfaFormu_Load(object sender, EventArgs e)
        {

            StokCekme();
            NotCek();
            Fihrist();
            HareketCek();


            try
            {

                //Döviz krualarını çekme
                webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");

                //haberler
                XmlTextReader haber = new XmlTextReader("https://www.cnnturk.com/feed/rss/all/news");
                while (haber.Read())
                {
                    if (haber.Name == "title")
                    {
                        listBox1.Items.Add(haber.ReadString());

                    }
                }
            }
            catch //İnternet yoksa vs.**
            {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz");
                xtraTabControl1.Visible = false;
            }

        }

     


    }
}
