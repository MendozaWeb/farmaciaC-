using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;
using Controlador;
using System.Windows.Forms;

namespace Controlador
{
    public class DCategoria: InterfDao
    {
        private SqlConnection con = null;

       

        public void add(Categoria obj)
        {
            con = Conexion.getCon();
            con.Open();
             string query = "SP_INS_ACT_CATEG";
             SqlCommand cmd = new SqlCommand(query, con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@ID",obj.getCod);
             cmd.Parameters.AddWithValue("@NOM", obj.getNom);
            cmd.Parameters.AddWithValue("@DES", obj.getDes);
            cmd.Parameters.AddWithValue("@T", 'G');
             if (cmd.ExecuteNonQuery() > 0)
              MessageBox.Show("Datos registrados");
            else
             MessageBox.Show("No se registro");
            con.Close();
            //con = Conexion.getCon();
            //con.Open();
            //string query = "INSERT INTO Categoria VALUES("
            //+"'" + obj.getCod + "',"
            //+"'" + obj.getNom + "',"
            //+"'" + obj.getDes + "'"
            //+")";

            //SqlCommand cmd = new SqlCommand(query, con);
            //if (cmd.ExecuteNonQuery() > 0)
            //MessageBox.Show("Datos registrados");
            //else
            //MessageBox.Show("No se registro");
            //con.Close();

        }

        public void delete(object cod)
        {
             con = Conexion.getCon();
             con.Open();
             string query = "SP_BUS_DEL_CATEG";
             SqlCommand cmd = new SqlCommand(query, con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@ID",cod);
            cmd.Parameters.AddWithValue("@T",'D');
             if (cmd.ExecuteNonQuery() > 0)
             MessageBox.Show("Registro Eliminado");
            else
            MessageBox.Show("No se elimino");
            con.Close();
            //con = Conexion.getCon();
            //con.Open();
            //string query = "Delete From Categoria Where id_cat='" + cod + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //if (cmd.ExecuteNonQuery() > 0)
            //MessageBox.Show("Registro Eliminado");
            //else
            //MessageBox.Show("No se elimino");
            //con.Close();
        }

        public DataTable getCargarLista(object bus)
        {
            DataTable dt = new DataTable();
            string query = "SP_BUS_DEL_CATEG";
            SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", bus);
            cmd.Parameters.AddWithValue("@T", 'B');
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
             adp.Fill(dt);
            return dt;
            //DataTable dt = new DataTable();
            //string query = "SELECT * FROM Categoria";
            //SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(dt);
            //return dt;
        }



        public void refresh(Categoria obj)
        {
            try
            {
                con = Conexion.getCon();
                con.Open();
                string query = "SP_INS_ACT_CATEG";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.getCod);
                cmd.Parameters.AddWithValue("@NOM", obj.getNom);
                cmd.Parameters.AddWithValue("@DES", obj.getDes);
                cmd.Parameters.AddWithValue("@T", "S");
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Datos registrados");
                else
                    MessageBox.Show("No se registro");
                con.Close();
                //con = Conexion.getCon();
                //con.Open();
                //string query = "UPDATE Categoria SET "
                //+"NOM_CAT='" + obj.getNom + "'"

                //+" WHERE ID_CAT=" + obj.getCod + "";

                //SqlCommand cmd = new SqlCommand(query, con);
                // if (cmd.ExecuteNonQuery() > 0)
                // MessageBox.Show("Datos Actualizado");
                // else
                //MessageBox.Show("No se puedo Actualizar");
                //con.Close();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString(),"titulo");
            }

             
        }
        

        public void add(Distrito obj)
        {
            throw new NotImplementedException();
        }

        public void add(Proveedor obj)
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
            throw new NotImplementedException();
        }

        public void refresh(Proveedor obj)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
