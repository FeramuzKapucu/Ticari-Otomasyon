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
    public partial class MusterilerFormu : Form
    {
        public object Sqlcommand { get; private set; }

        public MusterilerFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        MusterilerORM morm = new MusterilerORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();
        private void Loading() //Silme Yükleme Güncelleme  sonrası işlemler
        {
            int max = 0;
            gridControl1.DataSource = morm.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_max_musteriID", Tools.Baglanti);
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

            txtad.Text = "";
            txtsoyad.Text = "";
            msktlf.Text = "";
            msktlf2.Text = "";
            msktc.Text = "";
            txtmail.Text = "";
            txtvergi.Text = "";
            rchadres.Text = "";

            cmbil.Properties.Items.Clear();
            cmbil.Text = "";
            cmbilce.Text = "";

            sehirlistele();
        }

        private void sehirlistele() //Şehirleri combobox a çeken method
        {
            SqlCommand cmd = new SqlCommand("Select SEHIR from Iller", Tools.Baglanti);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            cmd.Connection.Close();
        }


        private void MusterilerFormu_Load(object sender, EventArgs e)
        {
            Loading();

        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((txtad.Text != "") && (txtsoyad.Text != "") && (msktlf.Text != "") && (msktlf2.Text != "") && (msktc.Text != "") && (txtmail.Text != "") && (txtvergi.Text != "") && (rchadres.Text != "") && (cmbil.SelectedIndex != -1) && (cmbilce.SelectedIndex != -1)) //Urun eklendi
            {

                errorProvider1.Clear();
                Musteriler musteri = new Musteriler();
                musteri.ID =Convert.ToInt32(txtid.Text);
                musteri.AD = txtad.Text.Trim().ToUpper();
                musteri.SOYAD = txtsoyad.Text.Trim().ToUpper();
                musteri.TELEFON1 = msktlf.Text;
                musteri.TELEFON2= msktlf2.Text;
                musteri.TC = msktc.Text;
                musteri.MAIL = txtmail.Text.Trim();
                musteri.IL = cmbil.Text;
                musteri.ILCE = cmbilce.Text;
                musteri.ADRES = rchadres.Text;
                musteri.VERGIDAIRE = txtvergi.Text.Trim().ToUpper();
                try
                {
                    int etk =Convert.ToInt16(morm.Insert(musteri));
                    
                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Müşteri Başarılı Bir Şekilde Eklendi");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Musteri;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Aynı Tc numarasına Sahip İki Adet Müşteri Ekleyemezsiniz");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Müşteri Eklemesi Sırasında Bir Hata Oluştu");
                }

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(txtad, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsoyad, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf2, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktc, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtmail, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(cmbil, "Bir İl Seçiniz");
                errorProvider1.SetError(cmbilce, "Bir İlçe Seçiniz");
            }
        } // Kaydetme işlemi sonu

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e) // Seçilen il e göre ilçelerin combobox a taşınmsı
        {
            int secilen = 0;
            cmbilce.Properties.Items.Clear();//Daha önceden secilip eklenmişleri siliyor.
            secilen = cmbil.SelectedIndex + 1;
            SqlCommand cmd = new SqlCommand("Select ILCE from Ilceler where SEHIR=@s1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@s1", secilen);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            cmd.Connection.Close();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) // tıklanılan nesnenin özelliklerini yan tarafa taşıma
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            txtad.Text = row["AD"].ToString();
            txtsoyad.Text = row["SOYAD"].ToString();
            msktlf.Text = row["TELEFON1"].ToString();
            msktlf2.Text = row["TELEFON2"].ToString();
            msktc.Text = row["TC"].ToString();
            txtmail.Text = row["MAIL"].ToString();
            txtvergi.Text = row["VERGIDAIRE"].ToString();
            rchadres.Text = row["ADRES"].ToString();
            cmbil.Text = row["IL"].ToString();
            cmbilce.Text = row["ILCE"].ToString();
        }

        //private void btnsilme_Click(object sender, EventArgs e)
        //{
        //    if (txtid.Text == row["ID"].ToString()) // Silme İşlemi için Müşteri Seçilmiş
        //    {
        //        DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Müşteri Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        //        if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
        //        {
        //            Musteriler musteri = new Musteriler();
        //            musteri.ID = Convert.ToInt32(txtid.Text);
        //            musteri.AD = txtad.Text.Trim().ToUpper();
        //            musteri.SOYAD = txtsoyad.Text.Trim().ToUpper();
        //            musteri.TELEFON1 = msktlf.Text;
        //            musteri.TELEFON2 = msktlf2.Text;
        //            musteri.TC = msktc.Text;
        //            musteri.MAIL = txtmail.Text.Trim();
        //            musteri.IL = cmbil.Text;
        //            musteri.ILCE = cmbilce.Text;
        //            musteri.ADRES = rchadres.Text;
        //            musteri.VERGIDAIRE = txtvergi.Text.Trim().ToUpper();
        //            int etk = Convert.ToInt16(morm.Delete(musteri));
        //            if (etk > 0) //Silme Gerçekleşti
        //            {
        //                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
        //                Loading();
        //            }
        //            else // Silme İşlemi Sırasında Bir Hata Oluştu
        //            {
        //                MessageBox.Show("Silme İşlemi Sırasında Bir Hata Oluştu");
        //                Loading();
        //            }


        //        }
        //        else // Silme İşlemi Onaylanmamış
        //        {
        //            MessageBox.Show("Silme İşlemi İptal Edildi");
        //            Loading();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen Silmek İstediniz Müşteriyi Seçiniz"); // Silme İşlemi İçin Müşteri Seçilmemiş
        //    }

        //}// Silme İşlemi Sonu

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Müşteri Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Müşteri Bilgileri\n\n\n  Ad: {1}\n Soayad: {2}\n Telefon 1 : {3}\n Telefon 2 : {4}\n Tc : {5}\n Mail: {6}\n İl  : {7}\n İlçe : {8}\n Vergi Dairesi :{9}\n Adres : {10}  Şeklinde Güncellensin Mi ?", txtid.Text, txtad.Text, txtsoyad.Text, msktlf.Text, msktlf2.Text, msktc.Text, txtmail.Text, cmbil.Text, cmbilce.Text, txtvergi.Text, rchadres.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Musteriler musteri = new Musteriler();
                    musteri.ID = Convert.ToInt32(txtid.Text);
                    musteri.AD = txtad.Text.Trim().ToUpper();
                    musteri.SOYAD = txtsoyad.Text.Trim().ToUpper();
                    musteri.TELEFON1 = msktlf.Text;
                    musteri.TELEFON2 = msktlf2.Text;
                    musteri.TC = msktc.Text;
                    musteri.MAIL = txtmail.Text.Trim();
                    musteri.IL = cmbil.Text;
                    musteri.ILCE = cmbilce.Text;
                    musteri.ADRES = rchadres.Text;
                    musteri.VERGIDAIRE = txtvergi.Text.Trim().ToUpper();
                    int etk = Convert.ToInt16(morm.Update(musteri));
                    if (etk > 0) //Güncelleme Gerçekleşti
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Updating;
                        kayit.IslemForm = IslemForm.Musteri;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else // Güncelleme İşlemi Sırasında Bir Hata Oluştu
                    {
                        MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu\n\nAynı Tc numarasına Sahip İki Adet Müşteri Olmadığından Emin Olun\n\nYa Da Daha Sonra Tekrar Deneyiniz ");
                       
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Müşteriyi Seçiniz"); // Güncelleme İşlemi İçin Nesne Seçilmemiş
            }
        } // Güncelleme Sonu
    }
}
