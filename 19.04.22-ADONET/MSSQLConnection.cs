using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._22_ADONET
{
    public static class MSSQLConnection
    {
        public static SqlConnection SqlConnection= new SqlConnection("Server=Zeynel;Database=YeniHoca;Integrated security=true");
    }
}
