using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;
using System.Windows.Forms;

namespace Controlador
{
    public class DSalida:InterfDao
    {
        private SqlConnection con = null;

        public void add(Producto obj)
        {
           
        }

        public void delete(object cod)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "SP_BUS_DEL_SALIDA";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", cod);
            cmd.Parameters.AddWithValue("@T", 'D');
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Registro Eliminado");
            else
                MessageBox.Show("No se elimino");
            con.Close();
        }

        public DataTable getCargarLista(object bus)
        {
            DataTable dt = new DataTable();
            string query = "SP_BUS_DEL_SALIDA";
            SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", bus);
            cmd.Parameters.AddWithValue("@T", 'B');
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }
        public void refresh(Producto obj)
        {
           
        }


        public void add(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public void add(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void add(Distrito obj)
        {
            throw new NotImplementedException();
        }

        public void add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void add(Entrada obj)
        {
            throw new NotImplementedException();
        }

        public void add(Salida obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "SP_ING_ACT_SALIDA";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obj.getCod);
            cmd.Parameters.AddWithValue("@FECH", obj.getFech);
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", obj.getCodProd.getCod);
            cmd.Parameters.AddWithValue("@CANT", obj.getCant);
            cmd.Parameters.AddWithValue("@ID_USUARIO", obj.getCodUsu.getCod);
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", obj.getCodProv.getCod);
            cmd.Parameters.AddWithValue("@T", 'G');


            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos registrados");
            else
                MessageBox.Show("No se registro");
            con.Close();
        }

        public void refresh(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Entrada obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Salida obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "SP_ING_ACT_SALIDA";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obj.getCod);
            cmd.Parameters.AddWithValue("@FECH", obj.getFech);
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", obj.getCodProd.getCod);
            cmd.Parameters.AddWithValue("@CANT", obj.getCant);
            cmd.Parameters.AddWithValue("@ID_USUARIO", obj.getCodUsu.getCod);
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", obj.getCodProv.getCod);
            cmd.Parameters.AddWithValue("@T", 'G');
            MessageBox.Show("" + cmd.ExecuteNonQuery());
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos registrados");
            else
                MessageBox.Show("No se registro");
            con.Close();
        }
        
    }
}
