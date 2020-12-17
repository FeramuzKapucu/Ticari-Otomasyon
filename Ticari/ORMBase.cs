using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Ticari
{
    public class ORMBase<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                // type of ile generic elemanın tipi belirlendi
                return typeof(T).Name;
            }
        }
        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_sil", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            //T elemanı içindeki property lerin hepsinin çekip bir dizi şeklinde properties ' e verdi.
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo pi in properties)
            {
                string name = pi.Name;
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

            return Tools.Exec(cmd);
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Ekle", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            //T elemanı içindeki property lerin hepsinin çekip bir dizi şeklinde properties ' e verdi.
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo pi in properties)
            {
                string name = pi.Name;
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

            return Tools.Exec(cmd);
        }

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tbl = new DataTable();

            adp.Fill(tbl);

            return tbl;
        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            //T elemanı içindeki property lerin hepsinin çekip bir dizi şeklinde properties ' e verdi.
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo pi in properties)
            {
                string name = pi.Name;
                object value = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

            return Tools.Exec(cmd);
        }
    }
}
