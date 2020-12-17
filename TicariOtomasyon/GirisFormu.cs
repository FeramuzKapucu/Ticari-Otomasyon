using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari.Entity;
using Ticari.Facade;

namespace TicariOtomasyon
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            PersonellerORM porm = new PersonellerORM(); 
            Personeller personel = new Personeller();   // buton tıklanınca adminler sınıfından bir instance oluşturup tc ve şifre bilgisi textboxlara göre oluşturuluyor oluşturulan nesne personllerorm deki girişyap fonskiyonunda kontrol ediliyor veri tabanından bir eşleşme varsa o aktif admin sayılıp adminmain formu açılıyır.
            //Eşleşme yoksa ise null geri dönüyor.Bu durumda kullanıcı adı ya da şifresi hatalı mesajı veriliyor.
            personel.TC = msktc.Text;
            personel.SIFRE = txtsifre.Text;

            Personeller aktif = porm.Girisyap(personel);
            if (aktif == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Parlo Yanlış");

            }
            else
            {
                PersonellerORM.AktifPersonel = aktif;

                MainForm frm = new MainForm();

                this.Hide();
                frm.Show();
            }
        }
    }
}
