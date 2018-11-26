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
    public class DDistrito : InterfDao 
    {

        private SqlConnection con = null;

        
        public void add(Distrito obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "INSERT INTO Distrito VALUES("
                            + "'" + obj.getNom + "'"
                            +")";

            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos registrados");
            else
                MessageBox.Show("No se registro");
            con.Close();
        }

        public void delete(object cod)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "Delete From Distrito Where cod_dist=" + cod + "";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Registro Eliminado");
            else
                MessageBox.Show("No se elimino");
            con.Close();
        }

        public DataTable getCargarLista(object bus)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Distrito";
            SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        

        public void refresh(Distrito obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "UPDATE Distrito SET "
                            + "NOM_DIST='" + obj.getNom + "'"
                            + " WHERE COD_DIST=" + obj.getCod + "";

            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos Actualizado");
            else
                MessageBox.Show("No se puedo Actualizar");
            con.Close();
        }
        public DataTable getCargarComboBox()
        {
            DataTable dt = new DataTable();
            con = Conexion.getCon();
            string query = "SELECT COD_DIST,NOM_DIST FROM DISTRITO ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public void add(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public void add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void refresh(Usuario obj)
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
