using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
    public partial class MailFormu : Form
    {
        public MailFormu()
        {
            InitializeComponent();
        }
        public string mail;
        private void MailFormu_Load(object sender, EventArgs e)
        {
            txtmail.Text = mail;
        }

        private void btngnder_Click(object sender, EventArgs e)
        {
            try
            {
                //Mail Gönderme
                MailMessage mesaj = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("fkapucu19@gmail.com", "17769445.google.FK.1");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                mesaj.To.Add(txtmail.Text);
                mesaj.From = new MailAddress("fkapucu19@gmail.com");
                mesaj.Subject = txtkonu.Text;
                mesaj.Body = rchmesaj.Text;
                smtp.Send(mesaj);
                MessageBox.Show("Mail Başarılı Bir Şekilde Gönderildi.");
            }
            catch
            {
                MessageBox.Show("Mesajınız Gönderilemedi Daha Sonra Tekrar Deneyiniz");
            }
           

        }
    }
}
