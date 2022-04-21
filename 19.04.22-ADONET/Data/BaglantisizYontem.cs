using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._22_ADONET.Data
{
    internal class BaglantisizYontem
    {
        public void Method()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kategoriler", "Server=Zeynel;Database=YeniHoca;Integrated Security=true");
            DataTable table = new DataTable();

            da.Fill(table);
            
        }
    }
}
