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
    public partial class FirmalarFormu : Form
    {
        public FirmalarFormu()
        {
            InitializeComponent();
        }
        DataRow row;

        FirmalarORM form = new FirmalarORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();

        private void Loading() // Silme Ekleme Değistirme ve yükleme sonrası ypaılacak işlemler
        {
            int max = 0;
            gridControl1.DataSource = form.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("prc_max_firmaID", Tools.Baglanti);
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
            txtsektor.Text = "";
            msktlf.Text = "";
            msktlf2.Text = "";
            msktlf3.Text = "";
            msktc.Text = "";
            txtmail.Text = "";
            mskfaks.Text = "";
            txtvergi.Text = "";
            txtyetkili.Text = "";
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
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Firmalar", Tools.Baglanti);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlCommand cmd = new SqlCommand("Select SEHIR from Iller", Tools.Baglanti);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            cmd.Connection.Close();
        }

        private void FirmalarFormu_Load(object sender, EventArgs e)
        {
            Loading();

        }




        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) // Tıklanana kaydın bilgileri yan tarafa geliyor
        {
            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            txtad.Text = row["AD"].ToString();
            txtyetkili.Text= row["YETKILIADSOYAD"].ToString();
            txtgorev.Text= row["YETKILISTATU"].ToString();
            txtsektor.Text = row["SEKTOR"].ToString();
            msktlf.Text = row["TELEFON1"].ToString();
            msktlf2.Text = row["TELEFON2"].ToString();
            msktlf3.Text = row["TELEFON3"].ToString();
            msktc.Text = row["YETKILITC"].ToString();
            txtmail.Text = row["MAIL"].ToString();
            mskfaks.Text = row["FAX"].ToString();
            txtvergi.Text = row["VERGIDAIRE"].ToString();
            rchadres.Text = row["ADRES"].ToString();
            cmbil.Text = row["IL"].ToString();
            cmbilce.Text = row["ILCE"].ToString();
        }

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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((txtad.Text != "") && (txtsektor.Text != "") && (msktlf.Text != "") && (msktlf2.Text != "") && (msktlf3.Text != "") && (mskfaks.Text != "") && (msktc.Text != "") && (txtmail.Text != "") && (txtyetkili.Text != "") && (txtgorev.Text != "") && (txtvergi.Text != "") && (rchadres.Text != "") && (cmbil.SelectedIndex != -1) && (cmbilce.SelectedIndex != -1)) //Urun eklendi
            {

                errorProvider1.Clear();
                Firmalar firma = new Firmalar();
                firma.ID =Convert.ToInt32(txtid.Text);
                firma.AD = txtad.Text.Trim().ToUpper();
                firma.SEKTOR = txtsektor.Text.Trim().ToUpper();
                firma.YETKILISTATU= txtgorev.Text.Trim().ToUpper();
                firma.YETKILIADSOYAD=txtyetkili.Text.Trim().ToUpper();
                firma.YETKILITC = msktc.Text;
                firma.TELEFON1 = msktlf.Text;
                firma.TELEFON2 = msktlf2.Text;
                firma.TELEFON3 = msktlf3.Text;
                firma.MAIL = txtmail.Text;
                firma.FAX = mskfaks.Text;
                firma.IL = cmbil.Text;
                firma.ILCE = cmbilce.Text;
                firma.VERGIDAIRE = txtvergi.Text;
                firma.ADRES = rchadres.Text;
                try
                {
                    int etk =Convert.ToInt32(form.Insert(firma));

                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Firma Başarılı Bir Şekilde Eklendi");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Firma;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);

                        Loading();
                    }
                }
                catch
                {
                    MessageBox.Show("Firma Eklemesi Sırasında Bir Hata Oluştu");
                }
               

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(txtad, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsektor, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtyetkili, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtgorev, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf2, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf3, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(mskfaks, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktc, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtmail, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtvergi, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rchadres, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(cmbil, "Bir İl Seçiniz");
                errorProvider1.SetError(cmbilce, "Bir İlçe Seçiniz");
            }
        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

    
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Müşteri Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Firma Bilgileri\n\n\n  Ad: {1}\n Sektor: {2}\n Yetkili  : {3}\n Yetkili Görev : {4}\n Yetkili Tc : {5}\n Telefon 1: {6}\n Telfon 2  : {7}\n Telefon 3 : {8}\n Faks :{9}\n Mail : {10}\n İl : {11}\n İlçe : {12}\n Vergi Dairesi : {13}\n Adres : {14}\n\n\n\n  Şeklinde Güncellensin Mi ?", txtid.Text, txtad.Text, txtsektor.Text, txtyetkili.Text, txtgorev.Text, msktc.Text, msktlf.Text, msktlf2.Text, msktlf3.Text, mskfaks.Text, txtmail.Text, cmbil.Text, cmbilce.Text, txtvergi.Text, rchadres.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    Firmalar firma = new Firmalar();
                    firma.ID = Convert.ToInt32(txtid.Text);
                    firma.AD = txtad.Text.Trim().ToUpper();
                    firma.SEKTOR = txtsektor.Text.Trim().ToUpper();
                    firma.YETKILISTATU = txtgorev.Text.Trim().ToUpper();
                    firma.YETKILIADSOYAD = txtyetkili.Text.Trim().ToUpper();
                    firma.YETKILITC = msktc.Text;
                    firma.TELEFON1 = msktlf.Text;
                    firma.TELEFON2 = msktlf2.Text;
                    firma.TELEFON3 = msktlf3.Text;
                    firma.MAIL = txtmail.Text;
                    firma.FAX = mskfaks.Text;
                    firma.IL = cmbil.Text;
                    firma.ILCE = cmbilce.Text;
                    firma.VERGIDAIRE = txtvergi.Text;
                    firma.ADRES = rchadres.Text;
                    int etk =Convert.ToInt32(form.Update(firma));
                    if (etk > 0) //Güncelleme Gerçekleşti
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");

                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Updating;
                        kayit.IslemForm = IslemForm.Firma;
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Firma Bilgisini Seçiniz"); // Güncelleme İşlemi İçin Nesne Seçilmemiş
            }
        } // Güncelleme SOnu
    }
}
