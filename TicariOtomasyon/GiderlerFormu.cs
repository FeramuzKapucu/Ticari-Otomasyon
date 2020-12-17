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
    public partial class GiderlerFormu : Form
    {
        public GiderlerFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        GiderlerORM gorm = new GiderlerORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();
        private void Loading()
        {
            int max = 0;
            gridControl1.DataSource = gorm.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_maxGiderlerID", Tools.Baglanti);
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

            cmbay.SelectedIndex = -1;
            cmbyil.SelectedIndex = -1;
            txtelektrik.Text = "";
            txtsu.Text = "";
            txtdogalgaz.Text = "";
            txtinternet.Text = "";
            txtekstra.Text = "";
            rchnotlar.Text = "";
        }

        private void GiderlerFormu_Load(object sender, EventArgs e)
        {
            Loading();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if ((txtelektrik.Text != "") && (txtsu.Text != "") && (txtdogalgaz.Text != "") && (txtinternet.Text != "") && (txtekstra.Text != "") && (rchnotlar.Text != "") && (cmbay.SelectedIndex != -1) && (cmbyil.SelectedIndex != -1)) //gider eklendi
            {

                errorProvider1.Clear();
                Giderler gider = new Giderler();
                try
                {
                    gider.ID = Convert.ToInt32(txtid.Text);
                    gider.AY = cmbay.Text;
                    gider.YIL = cmbyil.Text;
                    gider.ELEKTRIK = Convert.ToDouble(txtelektrik.Text);
                    gider.SU = Convert.ToDouble(txtsu.Text);
                    gider.DOGALGAZ = Convert.ToDouble(txtdogalgaz.Text);
                    gider.INTERNET = Convert.ToDouble(txtinternet.Text);
                    gider.EKSTRA = Convert.ToDouble(txtekstra.Text);
                    gider.NOTLAR = rchnotlar.Text;
                    try
                    {
                        int etk =Convert.ToInt32(gorm.Insert(gider));

                        if (etk > 0)
                        {
                            MessageBox.Show("Yeni Gider Kaydı Başarılı Bir Şekilde Eklendi");

                            Islem_Kayit kayit = new Islem_Kayit();
                            kayit.IslemID = 0;
                            kayit.NesneID = Convert.ToInt32(txtid.Text);
                            kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                            kayit.ISLEMTIPI = IslemTipi.Adding;
                            kayit.IslemForm = IslemForm.Gider;
                            kayit.ISLEMTARIH = DateTime.Now;
                            ikorm.Insert(kayit);

                            Loading();
                        }
                        else
                        {
                            MessageBox.Show("Gider Kaydı Eklemesi Sırasında Bir Hata Oluştu\n\nAynı Yıl ve Ay İçin Gider Kaydı Olup Olmadığını Kontrol Ediniz\n\nYa Da Temizle Butonuna Basıp Tekrar Deneyiniz");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Gider Kaydı Eklemesi Sırasında Bir Hata Oluştu\n\nTemizle Butonuna Basıp Tekrar Deneyiniz");
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen Giderler İçin Sayısal Değerler Giriniz\n\nÖrneğin : 17,99");
                }


            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(txtelektrik, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsu, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtdogalgaz, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtinternet, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtekstra, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rchnotlar, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(cmbay, "Lütfen Bir Ay Seçininiz");
                errorProvider1.SetError(cmbyil, "Lütfen Bir Yıl Seçininiz");
            }
        } //Ekleme İşlemi Sonu

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            cmbay.SelectedItem = (row["AY"]).ToString(); ;
            cmbyil.SelectedItem = (row["YIL"]).ToString(); ;
            txtelektrik.Text = row["ELEKTRIK"].ToString();
            txtsu.Text = row["SU"].ToString();
            txtdogalgaz.Text = row["DOGALGAZ"].ToString();
            txtinternet.Text = row["INTERNET"].ToString();
            txtekstra.Text = row["EKSTRA"].ToString();
            rchnotlar.Text = row["NOTLAR"].ToString();
        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnsilme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Silme İşlemi için Müşteri Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Gider Kaydı Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
                {
                    Giderler gider = new Giderler();
                    gider.ID = Convert.ToInt32(txtid.Text);
                    gider.AY = cmbay.Text;
                    gider.YIL = cmbyil.Text;
                    gider.ELEKTRIK = Convert.ToDouble(txtelektrik.Text);
                    gider.SU = Convert.ToDouble(txtsu.Text);
                    gider.DOGALGAZ = Convert.ToDouble(txtdogalgaz.Text);
                    gider.INTERNET = Convert.ToDouble(txtinternet.Text);
                    gider.EKSTRA = Convert.ToDouble(txtekstra.Text);
                    gider.NOTLAR = rchnotlar.Text;
                    int etk = Convert.ToInt32(gorm.Delete(gider));
                    if (etk > 0) //Silme Gerçekleşti
                    {
                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Deleting;
                        kayit.IslemForm = IslemForm.Gider;
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
                MessageBox.Show("Lütfen Silmek İstediniz Gider Kaydını Seçiniz"); // Silme İşlemi İçin Müşteri Seçilmemiş
            }
        } // Silme İşlemi SOnu

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Personel Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Gider Kaydı Bilgileri\n\n\n  Ay: {1}\n Yıl: {2}\n Elektrik : {3}\n Su : {4}\n Doğal Gaz: {5}\n İnternet  : {6}\n  : \n Ekstra :{7}\n Notlar : {8}\n Şeklinde Güncellensin Mi ?", txtid.Text, cmbay.Text, cmbyil.Text, txtelektrik.Text, txtsu.Text, txtdogalgaz.Text, txtinternet.Text, txtekstra.Text, rchnotlar.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Giderler gider = new Giderler();
                    try
                    {
                        gider.ID = Convert.ToInt32(txtid.Text);
                        gider.AY = cmbay.Text;
                        gider.YIL = cmbyil.Text;
                        gider.ELEKTRIK = Convert.ToDouble(txtelektrik.Text);
                        gider.SU = Convert.ToDouble(txtsu.Text);
                        gider.DOGALGAZ = Convert.ToDouble(txtdogalgaz.Text);
                        gider.INTERNET = Convert.ToDouble(txtinternet.Text);
                        gider.EKSTRA = Convert.ToDouble(txtekstra.Text);
                        gider.NOTLAR = rchnotlar.Text;
                        int etk = Convert.ToInt32(gorm.Update(gider));
                        if (etk > 0) //Güncelleme Gerçekleşti
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");

                            Islem_Kayit kayit = new Islem_Kayit();
                            kayit.IslemID = 0;
                            kayit.NesneID = Convert.ToInt32(txtid.Text);
                            kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                            kayit.ISLEMTIPI = IslemTipi.Updating;
                            kayit.IslemForm = IslemForm.Gider;
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
                    catch
                    {
                        MessageBox.Show("Lütfen Giderler İçin Sayısal Değerler Giriniz\n\nÖrneğin : 17,99");
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Gider Kaydını Seçiniz"); // Güncelleme İşlemi İçin Personel Seçilmemiş
            }
        } // Güncelleme İşlemi SOnu
    }
}
