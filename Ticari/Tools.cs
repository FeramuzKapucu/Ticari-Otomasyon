using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticari
{
    public class Tools
    {
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                    baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbTicariOtomasyon;Integrated Security=True");
                return baglanti;
            }

        }
        public static bool Exec(SqlCommand cmd)
        {

            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }

        }
    }
}
