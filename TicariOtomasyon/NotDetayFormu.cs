using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class NotDetayFormu : Form
    {
        public NotDetayFormu()
        {
            InitializeComponent();
        }
        public string not;
        private void NotDetayFormu_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = not;
        }
    }
}
