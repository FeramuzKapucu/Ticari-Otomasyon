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
    public partial class RehberFormu : Form
    {
        public RehberFormu()
        {
            InitializeComponent();
        }

        private void RehberFormu_Load(object sender, EventArgs e)
        {
            // Müşeri bilgileri
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,TELEFON1,TELEFON2,MAIL from Musteriler", Tools.Baglanti);
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Firma Bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL  from Firmalar", Tools.Baglanti);
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MailFormu mlfrm = new MailFormu();
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(row!=null)
            {
                mlfrm.mail = row["MAIL"].ToString();
            }
            mlfrm.ShowDialog();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            MailFormu mlfrm = new MailFormu();
            DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (row != null)
            {
                mlfrm.mail = row["MAIL"].ToString();
            }
            mlfrm.ShowDialog();
           
        }
    }
}
