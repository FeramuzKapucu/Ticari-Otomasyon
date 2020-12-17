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
    public partial class PersonellerFormu : Form
    {
        public PersonellerFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        PersonellerORM porm = new PersonellerORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();
        private void Loading() //Silme Yükleme Güncelleme  sonrası işlemler
        {
            int max = 0;
            gridControl1.DataSource = porm.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_maxPersonelID", Tools.Baglanti);
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
            msktc.Text = "";
            txtmail.Text = "";
            txtgorev.Text = "";
            rchadres.Text = "";

            cmbil.Properties.Items.Clear();
            cmbil.Text = "";
            cmbilce.Text = "";
            errorProvider1.Clear();

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
        private void PersonellerFormu_Load(object sender, EventArgs e)
        {
            Loading();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if ((txtad.Text != "") && (txtsoyad.Text != "") && (msktlf.Text != "") &&  (msktc.Text != "") && (txtmail.Text != "") && (txtgorev.Text != "") && (rchadres.Text != "") && (cmbil.SelectedIndex != -1) && (cmbilce.SelectedIndex != -1)) //Personel eklendi
            {

                errorProvider1.Clear();
                Personeller personel = new Personeller();
                personel.ID =Convert.ToInt32(txtid.Text);
                personel.AD = txtad.Text.Trim().ToUpper();
                personel.SOYAD=txtsoyad.Text.Trim().ToUpper();
                personel.TELEFON = msktlf.Text;
                personel.TC = msktc.Text;
                personel.SIFRE = "0000";
                personel.MAIL = txtmail.Text;
                personel.IL = cmbil.Text;
                personel.ILCE = cmbilce.Text;
                personel.ADRES = rchadres.Text;
                personel.GOREV=txtgorev.Text.Trim().ToUpper();
                try
                {
                    int etk =Convert.ToInt32(porm.Insert(personel));

                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Personel Başarılı Bir Şekilde Eklendi");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Personel;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Personel Eklemesi Sırasında Bir Hata Oluştu\nAynı Tc Numarasına Sahip İki Adet Personel Kaydetemezsiniz\n\nBöyle Bir Kayıt eklemeye Çalışmadıysanız Daha Sonra Tekrar Deneyebilirsiniz.");
                    }
                }
                catch
                {
                    MessageBox.Show("Personel Eklemesi Sırasında Bir Hata Oluştu");
                }

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(txtad, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsoyad, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktc, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtmail, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtgorev, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rchadres, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(cmbil, "Bir İl Seçiniz");
                errorProvider1.SetError(cmbilce, "Bir İlçe Seçiniz");
            }
        } // Eklmem İşlemi SOnu

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            txtad.Text = row["AD"].ToString();
            txtsoyad.Text = row["SOYAD"].ToString();
            msktlf.Text = row["TELEFON"].ToString();
            msktc.Text = row["TC"].ToString();
            txtmail.Text = row["MAIL"].ToString();
            txtgorev.Text = row["GOREV"].ToString();
            rchadres.Text = row["ADRES"].ToString();
            cmbil.Text = row["IL"].ToString();
            cmbilce.Text = row["ILCE"].ToString();

            SqlCommand cmd = new SqlCommand("Select SIFRE from Personeller where ID=@p1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@p1", txtid.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblsifre.Text = dr[0].ToString();
            }
            cmd.Connection.Close();
        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Personel Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Müşteri Bilgileri\n\n\n  Ad: {1}\n Soayad: {2}\n Telefon 1 : {3}\n Tc : {4}\n Mail: {5}\n İl  : {6}\n İlçe : {7}\n Adres :{8}\n Görev : {9}  Şeklinde Güncellensin Mi ?", txtid.Text, txtad.Text, txtsoyad.Text, msktlf.Text, msktc.Text, txtmail.Text, cmbil.Text, cmbilce.Text, txtgorev.Text, rchadres.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Personeller personel = new Personeller();
                    personel.ID = Convert.ToInt32(txtid.Text);
                    personel.AD = txtad.Text.Trim().ToUpper();
                    personel.SOYAD = txtsoyad.Text.Trim().ToUpper();
                    personel.TELEFON = msktlf.Text;
                    personel.TC = msktc.Text;
                    personel.SIFRE = lblsifre.Text;
                    personel.MAIL = txtmail.Text;
                    personel.IL = cmbil.Text;
                    personel.ILCE = cmbilce.Text;
                    personel.ADRES = rchadres.Text;
                    personel.GOREV = txtgorev.Text.Trim().ToUpper();
                    try
                    {
                        int etk =Convert.ToInt32(porm.Update(personel));
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
                            MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu\n\nAynı Tc numarasına Sahip İki Adet Personel Olmadığından Emin Olun\n\nYa Da Daha Sonra Tekrar Deneyiniz ");
                            Loading();
                        }

                    }
                    catch
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Personeli Seçiniz"); // Güncelleme İşlemi İçin Personel Seçilmemiş
            }
        } //Güncelleme Sonu
    }
}
