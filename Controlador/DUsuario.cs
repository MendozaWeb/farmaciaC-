using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Controlador
{
    public class DUsuario : InterfDao
    {
        private SqlConnection con = null;

        public int getValidar(string nom,string pas)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "SP_LOGIN_USU";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM", nom);
            cmd.Parameters.AddWithValue("@PASS", pas);

            //PROCEDIMIENTO ALMACENADO CON SALIDA
            SqlParameter pa = new SqlParameter("@RES",SqlDbType.Int);
            pa.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pa);
            cmd.ExecuteNonQuery();
            //FIN

            int r = int.Parse(cmd.Parameters[2].Value.ToString());

            con.Close();
            return r;
        }

        
        public void add(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void add(Usuario obj)
        {

            con = Conexion.getCon();
            con.Open();
            string query = "SP_ING_LOGIN";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM", obj.getnom);
            cmd.Parameters.AddWithValue("@PAS", obj.getpass);
            cmd.Parameters.AddWithValue("@TIPO", obj.gettipo);
            cmd.Parameters.AddWithValue("@T", 'G');
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos registrados");
            else
                MessageBox.Show("No se registro");
            con.Close();
        }

        public void add(Distrito obj)
        {
            throw new NotImplementedException();
        }

        

        public void delete(object cod)
        {
            throw new NotImplementedException();
        }

        public DataTable getCargarLista(object bus)
        {
            DataTable dt = new DataTable();
            string query = "SP_ING_ACT_LOGIN";
            SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM", bus);
            cmd.Parameters.AddWithValue("@T", 'B');
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public void refresh(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void add(Entrada obj)
        {
            throw new NotImplementedException();
        }

        public void add(Salida obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Entrada obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Salida obj)
        {
            throw new NotImplementedException();
        }
    }
}
