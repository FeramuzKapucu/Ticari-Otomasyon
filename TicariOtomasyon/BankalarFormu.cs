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
    public partial class cmbfirma : Form
    {
        public cmbfirma()
        {
            InitializeComponent();
        }
        DataRow row;

        BankalarORM borm = new BankalarORM();
        MusterilerORM morm = new MusterilerORM();
        FirmalarORM form = new FirmalarORM();
        Islem_KayitORM ıkorm = new Islem_KayitORM();
        private void Loading()
        {
            int max = 0;

            //combobox a firma çekimi
            cmbfirm.DataSource = form.Select();
            cmbfirm.DisplayMember = "AD";
            cmbfirm.ValueMember = "ID";

            //combobox a Müşteri çekimi
            SqlDataAdapter adp = new SqlDataAdapter("Select ID,AD+' '+SOYAD as 'MUSTERI' from Musteriler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbmusteri.DataSource = dt;
            cmbmusteri.DisplayMember = "MUSTERI";
            cmbmusteri.ValueMember = "ID";

            gridControl1.DataSource = borm.Select();
            txtid.Properties.ReadOnly = true;
            SqlCommand cmd2 = new SqlCommand("prc_max_bankaID", Tools.Baglanti);
            cmd2.CommandType = CommandType.StoredProcedure;

            txtid.Focus();
            if (cmd2.Connection.State != ConnectionState.Open)
                cmd2.Connection.Open();
            SqlDataReader dr = cmd2.ExecuteReader(); // veri tabanından okuma işlemi

            while (dr.Read())
            {
                if (!DBNull.Value.Equals(dr["ID"])) //Daha Önceden kayıt yoksa 
                {
                    max = Convert.ToInt32(dr["ID"]);
                }

            }
            if (cmd2.Connection.State != ConnectionState.Closed)
                cmd2.Connection.Close();
            if (max == 0) //Daha önce kayıt yoksa max değeri 0 olarak gelir
            {
                txtid.Text = "1".ToString();

            }
            else
            {
                max += 1; // sonuç a 1 ekleniyor.(Bir sonraki iş ekleme işleminden dolayısıyla en yüksek id nin bir fazlası veri tabanında kaydedilir.
                txtid.Text = max.ToString(); // Eklenenecek id txtid ye yazılır.
            }

            txtbankaadi.Text = "";
            mskiban.Text = "";
            txtsube.Text = "";
            txtyetkili.Text = "";
            cmbil.Properties.Items.Clear();
            cmbil.Text = "";
            cmbilce.Text = "";
            mskhesabno.Text = "";
            msktlf.Text = "";
            sehirlistele();
            rdbfirma.Checked = false;
            rdbmusteri.Checked = false;

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



        private void BankalarFormu_Load(object sender, EventArgs e)
        {
            Loading();
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
            if ((txtbankaadi.Text != "") && (txtsube.Text != "") && (cmbil.SelectedIndex != -1) && (cmbilce.SelectedIndex != -1) && (mskiban.Text != "") && (mskhesabno.Text != "") && (txtyetkili.Text != "") && (msktlf.Text != "") && (rdbfirma.Checked == true || rdbmusteri.Checked == true) && (cmbfirm.SelectedIndex != -1 || cmbmusteri.SelectedIndex != -1)) //Banka eklendi
            {

                errorProvider1.Clear();
                Bankalar banka = new Bankalar();
                banka.ID = Convert.ToInt32(txtid.Text);
                banka.BANKAADI = txtbankaadi.Text.Trim().ToUpper();
                banka.SUBE = txtsube.Text.Trim().ToUpper();
                banka.IL = cmbil.Text;
                banka.ILCE = cmbilce.Text;
                banka.IBAN = mskiban.Text;
                banka.HESAPNO = mskhesabno.Text;
                banka.YETKILI = txtyetkili.Text.Trim().ToUpper();
                banka.TELEFON = msktlf.Text;
                banka.TARIH = DateTime.Now.Date;
                if (rdbfirma.Checked == true)
                {
                    banka.HESAPTURU = "FIRMA";
                    banka.FIRMAID_MUSTERID = Convert.ToInt32(cmbfirm.SelectedValue);
                }
                else
                {
                    banka.HESAPTURU = "SAHSI";
                    banka.FIRMAID_MUSTERID = Convert.ToInt32(cmbmusteri.SelectedValue);
                }


                try
                {
                    int etk = Convert.ToInt32(borm.Insert(banka));

                    if (etk > 0)
                    {
                        MessageBox.Show("Yeni Banka Kaydı Başarılı Bir Şekilde Eklendi");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID = etk;
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Adding;
                        kayit.IslemForm = IslemForm.Banka;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ıkorm.Insert(kayit);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Banka Kaydı Eklemesi Sırasında Bir Hata Oluştu");
                    }
                }
                catch
                {
                    MessageBox.Show("Banka Kaydı Eklemesi Sırasında Bir Hata Oluştu");
                }

            }
            else//Alanlar Boş Geçilirse
            {

                errorProvider1.SetError(txtbankaadi, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtsube, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(msktlf, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(mskiban, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(mskhesabno, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtyetkili, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(cmbil, "Bir İl Seçiniz");
                errorProvider1.SetError(cmbilce, "Bir İlçe Seçiniz");
                errorProvider1.SetError(rdbfirma, "Bunlardan Birini İşaretleyiniz");
                errorProvider1.SetError(rdbmusteri, "Bunlardan Birini İşaretleyiniz");

            }
        } // Ekleme İşlemi Sonu

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = row["ID"].ToString();
            txtbankaadi.Text = row["BANKAADI"].ToString();
            cmbil.Text = row["IL"].ToString();
            cmbilce.Text = row["ILCE"].ToString();
            txtsube.Text = row["SUBE"].ToString();
            mskiban.Text = row["IBAN"].ToString();
            mskhesabno.Text = row["HESAPNO"].ToString();
            txtyetkili.Text = row["YETKILI"].ToString();
            msktlf.Text = row["TELEFON"].ToString();

            SqlCommand cmd = new SqlCommand("Select HESAPTURU from Bankalar where ID=@b1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@b1", txtid.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString().Equals("FIRMA"))
                {
                    rdbfirma.Checked = true;

                }


                else
                {
                    rdbmusteri.Checked = true;

                }

            }
            cmd.Connection.Close();



        }

        private void btntemizleme_Click(object sender, EventArgs e)
        {
            Loading();
        }

        //ilişkili Kayıtlar olması hasebiyle silme işlemi komple kaldırdı

        //private void btnsilme_Click(object sender, EventArgs e)
        //{
        //    if (txtid.Text == row["ID"].ToString()) // Silme İşlemi için Müşteri Seçilmiş
        //    {
        //        DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Banka Kaydı Silinsin Mi ?", txtid.Text), "Silme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        //        if (cevap == DialogResult.Yes) // Silme İşlemi Onaylanmış
        //        {
        //            SqlCommand cmd = new SqlCommand("prc_bankalar_sil", Tools.Baglanti);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@ID", txtid.Text);
        //            cmd.Connection.Open();
        //            int etk = cmd.ExecuteNonQuery();
        //            cmd.Connection.Close();
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
        //        MessageBox.Show("Lütfen Silmek İstediniz Banka Kaydını Seçiniz"); // Silme İşlemi İçin Müşteri Seçilmemiş
        //    }


        //} // Silme İşlemi SOnu

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            if (txtid.Text == row["ID"].ToString()) // Güncelleme İşlemi için Personel Seçilmiş
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Banka Kaydı Bilgileri\n\n\n  Banka Adı: {1}\n İl: {2}\n İlçe : {3}\n Şube : {4}\n IBAN: {5}\n Hesap No  : {6}\n Yetkili : {7}\n Telefon :{8}\n \n\n  Şeklinde Güncellensin Mi ?", txtid.Text, txtbankaadi.Text, cmbil.Text, cmbilce.Text, txtsube.Text, mskiban.Text, mskhesabno.Text, txtyetkili.Text, msktlf.Text), "Güncelleme İşlemi Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Güncelleme İşlemi Onaylanmış
                {
                    errorProvider1.Clear();
                    Bankalar banka = new Bankalar();
                    banka.ID = Convert.ToInt32(txtid.Text);
                    banka.BANKAADI = txtbankaadi.Text.Trim().ToUpper();
                    banka.SUBE = txtsube.Text.Trim().ToUpper();
                    banka.IL = cmbil.Text;
                    banka.ILCE = cmbilce.Text;
                    banka.IBAN = mskiban.Text;
                    banka.HESAPNO = mskhesabno.Text;
                    banka.YETKILI = txtyetkili.Text.Trim().ToUpper();
                    banka.TELEFON = msktlf.Text;
                    banka.TARIH = DateTime.Now.Date;
                    if (rdbfirma.Checked == true)
                    {
                        banka.HESAPTURU = "FIRMA";
                        banka.FIRMAID_MUSTERID = Convert.ToInt32(cmbfirm.SelectedValue);
                    }
                    else
                    {
                        banka.HESAPTURU = "SAHSI";
                        banka.FIRMAID_MUSTERID = Convert.ToInt32(cmbmusteri.SelectedValue);
                    }
                    int etk = Convert.ToInt32(borm.Update(banka));
                    if (etk > 0) //Güncelleme Gerçekleşti
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
                        Islem_Kayit kayit = new Islem_Kayit();
                        kayit.IslemID = 0;
                        kayit.NesneID =Convert.ToInt32(txtid.Text);
                        kayit.IslemPersonel = PersonellerORM.AktifPersonel.AD + " " + PersonellerORM.AktifPersonel.SOYAD;
                        kayit.ISLEMTIPI = IslemTipi.Updating;
                        kayit.IslemForm = IslemForm.Banka;
                        kayit.ISLEMTARIH = DateTime.Now;
                        ıkorm.Insert(kayit);
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
                MessageBox.Show("Lütfen Güncellemek İstediniz Banka Kaydını Seçiniz"); // Güncelleme İşlemi İçin Personel Seçilmemiş
            }
        } // Güncelleme İşlemi Sonu

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

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Loading();
        }
    }
}
