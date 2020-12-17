using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari.Facade;

namespace TicariOtomasyon
{
    public partial class Islem_Kayit_Formu : Form
    {
        public Islem_Kayit_Formu()
        {
            InitializeComponent();
        }

        Islem_KayitORM ikorm = new Islem_KayitORM();

        private void Islem_Kayit_Formu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ikorm.Select();
        }
    }
}
