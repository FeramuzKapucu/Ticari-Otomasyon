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
    public partial class UrunlerFormu : Form
    {
        public UrunlerFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        UrunlerORM uorm = new UrunlerORM();
        Urun_TuruORM torm = new Urun_TuruORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();

        private void Loading() //Ürün Ekleme silme ve güncellenmsi sonrası
        {
            int max = 0;
            grdurunler.DataSource = uorm.Select();
            grduruntur.DataSource = torm.Select();
            cmbtur.DataSource = torm.Select();
            cmbtur.DisplayMember = "TUR";
            cmbtur.ValueMember = "ID";
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_max_urunID", Tools.Baglanti);
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

            cmbtur.Text = "";
            txtalis.Text = "";
            txtmarka.Text = "";
            txtsatis.Text = "";
            txtmodel.Text = "";
            nudadet.Value = 0;
            mskyil.Text = "";
            rchdetay.Text = "";
            txttur.Text = "";
            cmbtur.SelectedIndex = -1;
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        private void UrunlerFormu_Load(object sender, EventArgs e)
        {
            Loading();

        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((cmbtur.SelectedIndex != -1) && (txtmarka.Text != "") && (txtmodel.Text != "") && (nudadet.Value != 0) && (mskyil.Text != "") && (txtalis.Text != "") && (txtsatis.Text != "") && (rchdetay.Text != "")) //Alanlar Dolduruludu
            {
                Urunler urun = new Urunler();
                urun.ID = Convert.ToInt32(txtid.Text);
                urun.URUNAD = Convert.ToInt32(cmbtur.SelectedValue.ToString());
                urun.MARKA = txtmarka.Text.Trim().ToUpper();
                urun.MODEL = txtmodel.Text.Trim().ToUpper();
                urun.YIL = mskyil.Text;
                urun.ADET = Convert.ToInt16(nudadet.Value);
                urun.DETAY = rchdetay.Text;
                try //alış ve satış için uygun değer girilmezse
                {
                 
                    urun.ALISFIYAT = Convert.ToDouble(txtalis.Text);
                    urun.SATISFIYAT = Convert.ToDouble(txtsatis.Text);
                   

                    int etk = Convert.ToInt32(uorm.Insert(urun));
                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Ürün Kaydı Başarılı Bir şekilde Oluşturuldu");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Ürün;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kaydı Sırasın Bir Hata Oluştu Daha Sonra Tekrar Deneyiniz");
                    }
                }

                catch
                {
                    MessageBox.Show("Alış ve Satış Değerleri İçin Sayısal Değerler Giriniz.\n\nÖrneğin : 17,99");
                }
               
               
            }
            else//Alanlar Boş Geçilirse
            {
                errorProvider1.SetError(cmbtur, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtmarka, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtmodel, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(mskyil, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(nudadet, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtalis, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsatis, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rchdetay, "Bu Alan Boş Geçilemez");
            }


        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) // tıklanılan nesnenin özelliklerini yan tarafa taşıma
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            cmbtur.SelectedValue =Convert.ToInt32(row["URUNAD"]);
            txtmarka.Text = row["MARKA"].ToString();
            txtmodel.Text = row["MODEL"].ToString();
            mskyil.Text = row["YIL"].ToString();
            nudadet.Value = Convert.ToDecimal(row["ADET"]);
            txtalis.Text = row["ALISFIYAT"].ToString();
            txtsatis.Text = row["SATISFIYAT"].ToString();
            rchdetay.Text = row["DETAY"].ToString();

        }
        //ilişkili Satırlar hasebiyle silme işlemi kaldırıldı
        //private void btnsil_Click(object sender, EventArgs e) // Silme İşlemi
        //{
        //    if (txtid.Text == row["ID"].ToString()) // Silme İşlemi için Nesne Seçilmiş
        //    {
        //        DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Ürün Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        //        if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
        //        {
        //            Urunler urun = new Urunler();
        //            urun.ID = Convert.ToInt32(txtid.Text);
        //            urun.URUNAD = Convert.ToInt32(cmbtur.SelectedValue.ToString());
        //            urun.MARKA = txtmarka.Text.Trim().ToUpper();
        //            urun.MODEL = txtmodel.Text.Trim().ToUpper();
        //            urun.YIL = mskyil.Text;
        //            urun.ADET = Convert.ToInt16(nudadet.Value);
        //            urun.ALISFIYAT = Convert.ToDouble(txtalis.Text);
        //            urun.SATISFIYAT = Convert.ToDouble(txtsatis.Text);
        //            urun.DETAY = rchdetay.Text;
        //            int etk = Convert.ToInt32(uorm.Delete(urun));
        //            if (etk > 0) //Silme Gerçekleşti
        //            {
        //                MessageBox.Show("Ürün Kaydı Silme İşlemi Başarıyla Gerçekleşti");
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
        //        MessageBox.Show("Lütfen Silmek İstediniz Ürünü Seçiniz"); // Silme İşlemi İçin Nesne Seçilmemiş
        //    }


        //} // Silme İşlemi Sonu

        private void btntemizle_Click(object sender, EventArgs e) // Başlangıç Ekranı
        {
            Loading();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Nesne Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Ürün\n\n\n Ürün Ad: {1}\n Marka: {2}\n Model : {3}\n Yıl : {4}\n Adet : {5}\n AlışFiyat: {6}\n SatışFiyat : {7}\n Detay : {8}\n Şeklinde Güncellensin Mi ?", txtid.Text, cmbtur.Text, txtmarka.Text, txtmodel.Text, mskyil.Text, nudadet.Value, txtalis.Text, txtsatis.Text, rchdetay.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Urunler urun = new Urunler();
                    urun.ID = Convert.ToInt32(txtid.Text);
                    urun.URUNAD = Convert.ToInt32(cmbtur.SelectedValue.ToString());
                    urun.MARKA = txtmarka.Text.Trim().ToUpper();
                    urun.MODEL = txtmodel.Text.Trim().ToUpper();
                    urun.YIL = mskyil.Text;
                    urun.ADET = Convert.ToInt16(nudadet.Value);
                    urun.DETAY = rchdetay.Text;
                    try //alış ve satış için uygun değer girilmezse
                    {

                        urun.ALISFIYAT = Convert.ToDouble(txtalis.Text);
                        urun.SATISFIYAT = Convert.ToDouble(txtsatis.Text);
                        int etk = Convert.ToInt32(uorm.Update(urun));
                        if (etk > 0) //Güncelleme Gerçekleşti
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");

                            Islem_Kayit kayit = new Islem_Kayit();
                            kayit.IslemID = 0;
                            kayit.NesneID = Convert.ToInt32(txtid.Text);
                            kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                            kayit.ISLEMTIPI = IslemTipi.Updating;
                            kayit.IslemForm = IslemForm.Ürün;
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
                        MessageBox.Show("Lütfen Alış Ve Satış Fiyatları İçin Sayısal Değerler Giriniz");
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Ürünü Seçiniz"); // Güncelleme İşlemi İçin Nesne Seçilmemiş
            }
        } // Güncelleme Sonu

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnturekle_Click(object sender, EventArgs e)
        {
            if ((txttur.Text == ""))
            {
                errorProvider2.SetError(txttur, "Bu Alan Boş Geçilemez");
            }
            else
            {
                // Yeni admin ekleme işlemi
                Urun_Turu tur = new Urun_Turu();
                tur.TUR = txttur.Text.Trim().ToUpper();

                int id = Convert.ToInt32(torm.Insert(tur));
                if(id>0)
                {
                    MessageBox.Show("Yeni Tür Başarıyla Eklendi");
                    Loading();
                }
                else
                {
                    MessageBox.Show("Tür Eklemesi Sırasında Bir Hata Oluştu\nVar Olan Bir Türü Eklemediğinizden Emin Olun");
                }

            }
        }
    }
}
