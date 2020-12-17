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
using Ticari.Entity;
using Ticari.Facade;

namespace TicariOtomasyon
{
    public partial class NotlarFormu : Form
    {
        public NotlarFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        private void NotlarFormu_Load(object sender, EventArgs e)
        {
            Loading();
        }
        NotlarORM norm = new NotlarORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();
        private void Loading()
        {
            int max = 0;
            gridControl1.DataSource = norm.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_max_NotID", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;//

            txtid.Focus();
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader(); // veri tabanından okuma işlemi


            while (dr.Read())
            {
                if (!DBNull.Value.Equals(dr["ID"])) //Daha Önceden kayıt yoksa 
                {
                    max = Convert.ToInt32(dr["ID"]);
                }

            }
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
            if (max == 0) //Daha önce kayıt yoksa max değeri 0 olarak gelir
            {
                txtid.Text = "1".ToString();

            }
            else
            {
                max += 1; // sonuç a 1 ekleniyor.(Bir sonraki iş ekleme işleminden dolayısıyla en yüksek id nin bir fazlası veri tabanında kaydedilir.
                txtid.Text = max.ToString(); // Eklenenecek id txtid ye yazılır.
            }

            txtbaslik.Text ="";
            txtkime.Text ="";
            rchdetay.Text = "";
            
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if ((txtbaslik.Text != "") && (txtkime.Text != "") && (rchdetay.Text != "")) //Not eklendi
            {

                errorProvider1.Clear();
                Notlar not = new Notlar();
                not.ID = Convert.ToInt32(txtid.Text);
                not.TARIH = DateTime.Now.Date;
                not.SAAT =Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                not.BASLIK = txtbaslik.Text;
                not.DETAY = rchdetay.Text;
                not.OLUSTURAN = PersonellerORM.AktifPersonel.ID;
                not.KIME = txtkime.Text;
                try
                {
                    int etk = Convert.ToInt32(norm.Insert(not));
                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Not Kaydı Başarılı Bir Şekilde Eklendi");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Not;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else

                    {
                        MessageBox.Show("Not Kaydı Eklemesi Sırasında Bir Hata Oluştu");
                    }
                }
                catch
                {
                    MessageBox.Show("Not Kaydı Eklemesi Sırasında Bir Hata Oluştu");
                }

            }
            else//Alanlar Boş Geçilirse
            {

              
                errorProvider1.SetError(txtbaslik, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txthitap, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rchdetay, "Bu Alan Boş Geçilemez");
            }
        } //Ekleme İşlemi Sonu

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
         
            txtbaslik.Text = row["BASLIK"].ToString();
            rchdetay.Text = row["DETAY"].ToString();
            txtkime.Text = row["KIME"].ToString();


            SqlCommand cmd = new SqlCommand("Select TARIH,SAAT,OLUSTURAN from Notlar where ID=@n1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@n1", txtid.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbltarih.Text = dr[0].ToString();
                lblsaat.Text = dr[1].ToString();
                lblolusturan.Text = dr[2].ToString();
            }
            cmd.Connection.Close();

        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Silme İşlemi için Not Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Not Kaydı Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
                {
                    Notlar not = new Notlar();
                    not.ID = Convert.ToInt32(txtid.Text);
                    not.TARIH = Convert.ToDateTime(lbltarih.Text);
                    not.SAAT = Convert.ToDateTime(lblsaat.Text);
                    not.BASLIK = txtbaslik.Text;
                    not.DETAY = rchdetay.Text;
                    not.OLUSTURAN = Convert.ToInt32(lblolusturan.Text);
                    not.KIME = txtkime.Text;
                    int etk =Convert.ToInt32(norm.Delete(not));
                    if (etk > 0) //Silme Gerçekleşti
                    {
                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Deleting;
                        kayit.IslemForm = IslemForm.Not;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else // Silme İşlemi Sırasında Bir Hata Oluştu
                    {
                        MessageBox.Show("Silme İşlemi Sırasında Bir Hata Oluştu");
                        Loading();
                    }


                }
                else // Silme İşlemi Onaylanmamış
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi");
                    Loading();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediniz Not Kaydını Seçiniz"); // Silme İşlemi İçin Not Seçilmemiş
            }
        } //Silme İşlemi Sonu

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Not Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Not Kaydı Bilgileri\n\n\n  Başlık : {1}\\n Kime : {2}\n Detay: {3}\n\n\nŞeklinde Güncellensin Mi ?", txtid.Text, txtbaslik.Text, txtkime.Text, rchdetay.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Notlar not = new Notlar();
                    not.ID = Convert.ToInt32(txtid.Text);
                    not.TARIH = DateTime.Now.Date;
                    not.SAAT = Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    not.BASLIK = txtbaslik.Text;
                    not.DETAY = rchdetay.Text;
                    not.OLUSTURAN = PersonellerORM.AktifPersonel.ID;
                    not.KIME = txtkime.Text;
                    int etk = Convert.ToInt32(norm.Update(not));
          
                    if (etk > 0) //Güncelleme Gerçekleşti
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Updating;
                        kayit.IslemForm = IslemForm.Not;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else // Güncelleme İşlemi Sırasında Bir Hata Oluştu
                    {
                        MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu");
                        Loading();
                    }


                }
                else // Güncelleme İşlemi Onaylanmamış
                {
                    MessageBox.Show("Güncelleme İşlemi İptal Edildi");
                    Loading();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediniz Not Kaydını Seçiniz"); // Güncelleme İşlemi İçin Not Seçilmemiş
            }
        } // Güncelleme İşlemi Sonu

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            NotDetayFormu detay = new NotDetayFormu();
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (row != null)
            {
                detay.not = row["DETAY"].ToString();
            }
            detay.ShowDialog();
        }
    }
}
