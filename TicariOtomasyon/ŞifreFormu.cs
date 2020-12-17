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
    public partial class ŞifreFormu : Form
    {
        public ŞifreFormu()
        {
            InitializeComponent();
        }

        private void ŞifreFormu_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void Loading()
        {
            SqlCommand cmd = new SqlCommand("Select SIFRE from Personeller where ID=@p1", Tools.Baglanti);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@p1", PersonellerORM.AktifPersonel.ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txteski.Text = dr[0].ToString();
            }
            cmd.Connection.Close();
            txtyeni.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtyeni.Text!="")
            {
                errorProvider1.Clear();
                DialogResult cevap = MessageBox.Show(string.Format("Şifreniz {0} olarak güncellensin mi", txtyeni.Text), "Şifre Güncelleme Onay",MessageBoxButtons.YesNoCancel);
                if(cevap==DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Update Personeller set SIFRE=@p1 where ID=@p2", Tools.Baglanti);
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@p1", txtyeni.Text);
                    cmd.Parameters.AddWithValue("@p2", PersonellerORM.AktifPersonel.ID);
                    int etk = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    if (etk > 0)
                    {
                        MessageBox.Show("Şifre Değiştirme İşlemi Gerçeklşti");
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Değiştirme İşlemi Sırasında Bir Hata Oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi İptal Edildi");
                    Loading();
                }
               
            }
            else
            {
                errorProvider1.SetError(txteski, "Lütfen Şifrenizi Giriniz");
            }
        }
    }
}
