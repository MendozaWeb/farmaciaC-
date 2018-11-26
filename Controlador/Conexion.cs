using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controlador
{
    public class Conexion
    {
        public static SqlConnection con=null;


        public static SqlConnection getCon()
        {
            string query = "Data Source=.;Initial Catalog=FARMACIA;Integrated Security=True";
            con = new SqlConnection(query);
            return con;
        }

        public static void Open()
        {
            con.Open();
        }

        public static void Close()
        {
            con.Close();
        }
    }
}
