using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders24_Arama_Sayfalama
{
    public class cls_connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlcon = new SqlConnection("Server=MACHINEX;Database=NORTHWND;Trusted_Connection=True;");
                return sqlcon;
            }
        }
    }
}
