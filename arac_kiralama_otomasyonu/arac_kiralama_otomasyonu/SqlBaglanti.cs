using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama_otomasyonu
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=TAHIR\\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True;");

        public void BaglantiAc()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
        }

        public void BaglantiKapat()
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
                baglanti.Close();
        }
    }
}
