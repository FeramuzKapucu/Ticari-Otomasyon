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
    public partial class FaturaFormu : Form
    {
        public FaturaFormu()
        {
            InitializeComponent();
        }
        DataRow row;
        double miktar, tutar, fiyat;
        Fatura_BilgiORM fborm = new Fatura_BilgiORM();
        MusterilerORM morm = new MusterilerORM();
        FirmalarORM form = new FirmalarORM();
        Islem_KayitORM ikorm = new Islem_KayitORM();
        private void Loading() //Birinci Tab için loading işlemleri
        {
            int max = 0;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select FATURABILGIID,SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN from Fatura_Bilgi where SILINDI=0", Tools.Baglanti); // Silindi sütünü 0 olan faturalar gelir
            da.Fill(dt);
            gridControl1.DataSource = dt;
            txtid.Properties.ReadOnly = true;

            //combobox a Müşteri çekimi
            SqlDataAdapter adp = new SqlDataAdapter("Select ID,AD+' '+SOYAD as 'MUSTERI' from Musteriler", Tools.Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cmbmusteri.DataSource = tbl;
            cmbmusteri.DisplayMember = "MUSTERI";
            cmbmusteri.ValueMember = "ID";

            

            //combobox a firma çekimi
            cmbfirm.DataSource = form.Select();
            cmbfirm.DisplayMember = "AD";
            cmbfirm.ValueMember = "ID";

            SqlCommand cmd = new SqlCommand("prc_max_faturabilgiID", Tools.Baglanti);
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
            mskseri.Text = "";
            msksırano.Text = "";
            txtvergi.Text = "";
            txtteslimalan.Text = "";
            rdbfirma.Checked = false;
            rdbmusteri.Checked = false;
          

        }

        private void Loading2() //İkinci Tab için loading işlemleri
        {
            txttutar.Properties.ReadOnly = true;
            txtmarka.Properties.ReadOnly = true;
            txtmodel.Properties.ReadOnly = true;
            txtalis.Properties.ReadOnly = true;
            txtalis.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            mskfiyat.Text = 0.ToString();
            nudmiktar.Value = 0;
            txturunad.Text = "";
            cmbfaturaid.Text = "";
            cmbfaturaid.SelectedIndex = -1;
            cmburunid.SelectedIndex = -1;
            Faturaid();

            UrunCekme();

        }

        private void UrunCekme() //urun ID lerini Çeker
        {
            cmburunid.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select ID from Urunler", Tools.Baglanti);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmburunid.Items.Add(dr[0]);
            }
            cmd.Connection.Close();
        }

        private  void Faturaid()
        {
           
            cmbfaturaid.Items.Clear();//Daha önceden secilip eklenmişleri siliyor.
            SqlCommand cmd = new SqlCommand("Select FATURABILGIID from Fatura_Bilgi where SILINDI=0", Tools.Baglanti);
            if(cmd.Connection.State!= ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbfaturaid.Items.Add(dr[0]);
            }
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
        }
      

        private void FaturaFormu_Load(object sender, EventArgs e)
        {
            Loading();
            Loading2();
        }


        private void btnkaydet1_Click(object sender, EventArgs e)
        {
            if ((mskseri.Text != "") && (msksırano.Text != "")   && (txtvergi.Text != "") &&(txtteslimalan.Text != "") && (rdbfirma.Checked == true || rdbmusteri.Checked == true) && (cmbfirm.SelectedIndex != -1 || cmbmusteri.SelectedIndex != -1)) //Fatura Bilgi eklendi
            {

                errorProvider1.Clear();
                Fatura_Bilgi fbilgi = new Fatura_Bilgi();
                fbilgi.FATURABILGIID = Convert.ToInt32(txtid.Text);
                fbilgi.SERI =Convert.ToChar(mskseri.Text.ToUpper());
                fbilgi.SIRANO = msksırano.Text;
                fbilgi.TARIH = DateTime.Now.Date;
                fbilgi.SAAT = Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                fbilgi.VERGIDAIRE = txtvergi.Text.Trim().ToUpper();
                if (rdbfirma.Checked == true)
                {
                    fbilgi.ALICI = cmbfirm.Text;
                }
                else
                {
                    fbilgi.ALICI = cmbmusteri.Text;
                }
                fbilgi.TESLIMEDEN = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                fbilgi.TESLIMALAN =txtteslimalan.Text.Trim().ToUpper();
                fbilgi.SILINDI = false;

                try
                {
                    int etk = Convert.ToInt16(fborm.Insert(fbilgi));

                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Fatura Kaydı Başarılı Bir Şekilde Eklendi");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Fatura;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ikorm.Insert(kayit);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Fatura Kaydı Eklemesi Sırasında Bir Hata Oluştu\nFatura Seri ve Sıra No'su Daha öneden Kayıtlı Bir Fatura Olmadığını Kontrol Ediniz.");
                    }
                }
                catch(Exception )
                {
                    MessageBox.Show("Fatura Kaydı Eklemesi Sırasında Bir Hata Oluştu ");
                }
          

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(mskseri, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msksırano, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtvergi, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtteslimalan, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rdbfirma, "Bu ikisinden Birini Seçiniz.");
                errorProvider1.SetError(rdbmusteri, "Bu ikisinden Birini Seçiniz.");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["FATURABILGIID"].ToString();
            mskseri.Text= row["SERI"].ToString();
            msksırano.Text = row["SIRANO"].ToString();
            txtvergi.Text = row["VERGIDAIRE"].ToString();
            txtteslimalan.Text = row["TESLIMALAN"].ToString();
        }
      
        private void nudmiktar_ValueChanged(object sender, EventArgs e)  //Fiyat Hesaplama İşlemleri
        {
            miktar = Convert.ToDouble(nudmiktar.Value);
            try
            {
                fiyat = Convert.ToDouble(mskfiyat.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
            }
            catch
            {
                MessageBox.Show("Fiyat Değeri İçin Sayısal Değerler Giriniz.\n\nÖrneğin : 17,99");
            }
            
        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading2();
        }

        private void btnsil1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["FATURABILGIID"].ToString()) // Silme İşlemi için Fatura  Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Fatura Kaydı Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
                {
                    Fatura_Bilgi fbilgi = new Fatura_Bilgi();
                    fbilgi.FATURABILGIID = Convert.ToInt32(txtid.Text);
                    fbilgi.SERI = Convert.ToChar(mskseri.Text.ToUpper());
                    fbilgi.SIRANO = msksırano.Text;
                    fbilgi.TARIH = DateTime.Now.Date;
                    fbilgi.SAAT = Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    fbilgi.VERGIDAIRE = txtvergi.Text.Trim().ToUpper();
                    if (rdbfirma.Checked == true)
                    {
                        fbilgi.ALICI = cmbfirm.Text;
                    }
                    else
                    {
                        fbilgi.ALICI = cmbmusteri.Text;
                    }
                    fbilgi.TESLIMEDEN = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                    fbilgi.TESLIMALAN = cmbfirm.Text.Trim().ToUpper();
                    fbilgi.SILINDI = false;
                    int etk = Convert.ToInt32(fborm.Delete(fbilgi));
                    if (etk > 0) //Silme Gerçekleşti
                    {
                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Deleting;
                        kayit.IslemForm = IslemForm.Fatura;
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
                MessageBox.Show("Lütfen Silmek İstediniz Fatura Kaydını Seçiniz"); // Silme İşlemi İçin Müşteri Seçilmemiş
            }


        } //Silmeİşlemi Sonu


        //private void btnguncelle1_Click(object sender, EventArgs e) //Başka Tablolarla ilişkili kayıtlar olması hasebiye güncelleme işlemi iptal edilmiştir
        //{
        //    if (txtid.Text == row["FATURABILGIID"].ToString()) // Güncelleme İşlemi için Personel Seçilmiş
        //    {
        //        DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Fatura Kaydı Bilgileri\n\n\n  Seri: {1}\n Sıra No: {2}\n Tarih : {3}\n Saat : {4}\n Vergi Daire: {5}\n Alıcı : {6}\n Teslim Eden : {7}\n Teslim Alan :{8}\n\n\n  Şeklinde Güncellensin Mi ?", txtid.Text, mskseri.Text, msksırano.Text, txtvergi.Text, txtteslimalan.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        //        if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
        //        {
        //            SqlCommand cmd = new SqlCommand("prc_fatura_bilgi_update", Tools.Baglanti);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@FATURABILGIID", txtid.Text);
        //            cmd.Parameters.AddWithValue("@VERGIDAIRE", txtvergi.Text);
      
        //            cmd.Parameters.AddWithValue("@TESLIMALAN", txtteslimalan.Text);
        //            cmd.Connection.Open();
        //            int etk = cmd.ExecuteNonQuery();
        //            cmd.Connection.Close();
        //            if (etk > 0) //Güncelleme Gerçekleşti
        //            {
        //                MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
        //                Loading();
        //            }
        //            else // Güncelleme İşlemi Sırasında Bir Hata Oluştu
        //            {
        //                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu");
        //                Loading();
        //            }


        //        }
        //        else // Güncelleme İşlemi Onaylanmamış
        //        {
        //            MessageBox.Show("Güncelleme İşlemi İptal Edildi");
        //            Loading();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen Güncellemek İstediniz Fatura Kaydını Seçiniz"); // Güncelleme İşlemi İçin Fatura Kaydı Seçilmemiş
        //    }
        //} // Güncelleme Sonu

        private void rdbfirma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbfirma.Checked == true)
            {
                lblfirma.Visible = true;
                cmbfirm.Visible = true;
            }
            else
            {
                lblfirma.Visible = false;
                cmbfirm.Visible = false;
            }
        }

        private void rdbmusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmusteri.Checked == true)
            {
                lblmusteri.Visible = true;
                cmbmusteri.Visible = true;
            }
            else
            {
                lblmusteri.Visible = false;
                cmbmusteri.Visible = false;
            }
        }


        private void txtfiyat_EditValueChanged(object sender, EventArgs e)
        {
            miktar = Convert.ToDouble(nudmiktar.Value);
            try
            {
                fiyat = Convert.ToDouble(mskfiyat.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
            }
            catch
            {
                MessageBox.Show("Fiyat Değeri İçin Sayısal Değerler Giriniz.\n\nÖrneğin : 17,99");
            }
        }

        private void cmburunid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select TUR,MARKA,MODEL,ALISFIYAT,SATISFIYAT,ADET from Urunler as U join Urun_Turu as T on U.URUNAD=T.ID where U.ID=@u", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u", cmburunid.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txturunad.Text = dr[0].ToString();
                txtmarka.Text = dr[1].ToString();
                txtmodel.Text = dr[2].ToString();
                txtalis.Text = dr[3].ToString();
                mskfiyat.Text = dr[4].ToString();
                lbladet.Text= dr[5].ToString();
            }
            cmd.Connection.Close();
        }

        private void btntemizle1_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void cmbfaturaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select TARIH from Fatura_Bilgi where FATURABILGIID=@f1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@f1", cmbfaturaid.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbltarih.Text = dr[0].ToString();
            }
            cmd.Connection.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FaturaDetay fdet = new FaturaDetay();
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (row != null)
            {
                fdet.ID =Convert.ToInt32(row["FATURABILGIID"]);
            }
            fdet.ShowDialog();
        }

        Fatura_DetayORM fdorm = new Fatura_DetayORM();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((cmburunid.SelectedIndex != -1) && (nudmiktar.Value !=0)  && (cmbfaturaid.SelectedIndex!=-1) &&(!mskfiyat.Text.Equals(0) )) //Fatura Detay eklendi
            {

                errorProvider2.Clear();
                Fatura_Detay fdetay = new Fatura_Detay();
                fdetay.FATURADETAYID = 0;
                fdetay.URUNAD = txturunad.Text;
                fdetay.MARKA = txtmarka.Text;
                fdetay.MODEL = txtmodel.Text;
                fdetay.ALIS= Convert.ToDouble(txtalis.Text);
                if ( Convert.ToInt32(nudmiktar.Value) <= Convert.ToInt32(lbladet.Text))
                {
                    fdetay.MIKTAR = Convert.ToInt32(nudmiktar.Value);
                    try
                    {
                        fdetay.FIYAT = Convert.ToDouble(mskfiyat.Text);
                        fdetay.TUTAR = Convert.ToDouble(txttutar.Text);
                        fdetay.FATURAID = Convert.ToInt16(cmbfaturaid.Text);
                        fdetay.TARIH = Convert.ToDateTime(lbltarih.Text);
                        try
                        {
                            int etk = Convert.ToInt32(fdorm.Insert(fdetay));

                            if (etk > 0)
                            {
                                MessageBox.Show("Yeni Fatura Detay Kaydı Başarılı Bir Şekilde Eklendi");
                                SqlCommand cmd = new SqlCommand("Update URunler set ADET=@U1 where ID=@U2", Tools.Baglanti);
                                cmd.Connection.Open();
                                cmd.Parameters.AddWithValue("@U1", Convert.ToInt32(lbladet.Text) - Convert.ToInt32(nudmiktar.Value));
                                cmd.Parameters.AddWithValue("@U2", (cmburunid.Text));
                                cmd.ExecuteNonQuery();
                                cmd.Connection.Close();
                                Loading2();
                            }
                            else
                            {
                                MessageBox.Show("Fatura Detay  Kaydı Eklemesi Sırasında Bir Hata Oluştu ");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fatura Detay  Kaydı Eklemesi Sırasında Bir Hata Oluştu ");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Fiyat Değeri İçin Sayısal Değerler Giriniz.\n\nÖrneğin : 17,99");
                    }

                }
                else
                {
                    MessageBox.Show(string.Format("Seçili Ürünle İlgili Yeterli Stok Bulunmamaktadır.\n\nİstenilen Miktar : {0}\n\nStoktaki Miktar : {1}\n\nLÜtfen Düzenleyip Tekrar Giriniz", nudmiktar.Value, lbladet.Text));
                }

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider2.SetError(nudmiktar,"Lütfen Miktar Giriniz");
                errorProvider2.SetError(cmbfaturaid, "Lütfen Bir Fatura Seçiniz");
                errorProvider2.SetError(cmburunid, "Lütfen Ürün Seçiniz");
                errorProvider2.SetError(mskfiyat,"Lütfen Geçerli Bir Fiyat Giriniz.");
            }
        } //Ekleme İşlemi Sonu
    }
}
