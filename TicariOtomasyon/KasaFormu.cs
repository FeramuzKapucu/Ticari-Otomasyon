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
using Ticari.Facade;

namespace TicariOtomasyon
{
    public partial class KasaFormu : Form
    {
        public KasaFormu()
        {
            InitializeComponent();
        }
        int tutar = 0;

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            //ELektrik
            if(sayac>0 && sayac<=5)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,ELEKTRIK from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl9.Text = "ELEKRİK";
                 
            }
            //SU
            if (sayac > 5 && sayac <= 10)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,Su from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl9.Text = "SU";

            }
            //DOğalgaz
            if (sayac > 10 && sayac <= 15)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,DOGALGAZ from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl9.Text = "DOĞALGAZ";

            }
            //interent
            if (sayac > 15 && sayac <= 20)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,INTERNET from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl9.Text = "İNTERNET";


            }
            //Ekstra
            if (sayac > 20 && sayac <= 25)
            {
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,EKSTRA from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl9.Text = "EKSTRA";

            }
            if (sayac == 26)
                sayac = 0;
                
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            //ELektrik
            if (sayac2 > 0 && sayac2 <= 5)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,ELEKTRIK from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl10.Text = "ELEKRİK";

            }
            //SU
            if (sayac2 > 5 && sayac2 <= 10)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,Su from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl10.Text = "SU";

            }
            //DOğalgaz
            if (sayac2 > 10 && sayac2 <= 15)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,DOGALGAZ from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl10.Text = "DOĞALGAZ";

            }
            //interent
            if (sayac2 > 15 && sayac2 <= 20)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,INTERNET from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl10.Text = "İNTERNET";


            }
            //Ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("Select top 4 AY ,EKSTRA from Giderler order by ID Desc", Tools.Baglanti);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                cmd.Connection.Close();
                groupControl10.Text = "EKSTRA";

            }
            if (sayac2 == 26)
                sayac2 = 0;
        }

        
        GiderlerORM gorm = new GiderlerORM();

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
        Fatura_DetayORM fatura = new Fatura_DetayORM();
        private void KasaFormu_Load(object sender, EventArgs e)
        {
           gridControl1.DataSource = fatura.Select();
          
            gridControl3.DataSource = gorm.Select();
            //Toplam tutarı hesaplama

            // Bu AYın Toplam Tutarın hesaplanması
           
                SqlCommand kmt2 = new SqlCommand("Select Sum((FIYAT-ALIS)*MIKTAR)as KAZANC  from Fatura_Detay where TARIH BETWEEN @tarih1 and @tarih2", Tools.Baglanti);
            kmt2.Parameters.AddWithValue("@tarih2", DateTime.Now);
            kmt2.Parameters.AddWithValue("@tarih1", DateTime.Now.AddMonths(-1));
            kmt2.Connection.Open();
                SqlDataReader reader2 = kmt2.ExecuteReader();
                while (reader2.Read())
                {
                    tutar += Convert.ToInt32(reader2[0]);
                }
                kmt2.Connection.Close();
            
            lbltutar.Text = tutar.ToString() + " ₺";



            //Son Ayın Giderleri

            SqlCommand cmd2 = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA)  From Giderler order by Id", Tools.Baglanti);
            cmd2.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblodemeler.Text = dr2[0].ToString() + " ₺";
            }
            cmd2.Connection.Close();


            //Müşteri SAyısı

            SqlCommand cmd4 = new SqlCommand("Select Count(ID) from Musteriler", Tools.Baglanti);
            cmd4.Connection.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblmusteri.Text = dr4[0].ToString();
            }
            cmd4.Connection.Close();

            //Firma Sayısı

            SqlCommand cmd5 = new SqlCommand("Select Count(ID) from Firmalar", Tools.Baglanti);
            cmd5.Connection.Open();
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirma.Text = dr5[0].ToString();
            }
            cmd5.Connection.Close();

            //Firma Şehir Sayısı

            SqlCommand cmd6 = new SqlCommand("Select Count(DISTINCT IL) from Firmalar ", Tools.Baglanti);
            cmd6.Connection.Open();
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lblfirmasehir.Text = dr6[0].ToString();
            }
            cmd6.Connection.Close();

            //Müşteri Şehir Sayısı

            SqlCommand cmd7 = new SqlCommand("Select Count(DISTINCT IL) from Musteriler ", Tools.Baglanti);
            cmd7.Connection.Open();
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                lblmusterisehir.Text = dr7[0].ToString();
            }
            cmd7.Connection.Close();

            //Personel  Sayısı

            SqlCommand cmd8 = new SqlCommand("Select ID from Personeller ", Tools.Baglanti);
            cmd8.Connection.Open();
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                lblpersonel.Text = dr8[0].ToString();
            }
            cmd8.Connection.Close();

            //Toplam Ürün Sayısı

            SqlCommand cmd9 = new SqlCommand("Select Sum(ADET) from Urunler ", Tools.Baglanti);
            cmd9.Connection.Open();
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {
                lblstok.Text = dr9[0].ToString();
            }
            cmd9.Connection.Close();






        }




    }




}
