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

namespace TicariOtomasyon
{
    public partial class FaturaDetay : Form
    {
        public FaturaDetay()
        {
            InitializeComponent();
        }
        public int ID;
        private void FaturaDetay_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * from Fatura_Detay where FATURAID=@f1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@f1", ID);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            gridControl1.DataSource = dt;

        }

       
    }
}
