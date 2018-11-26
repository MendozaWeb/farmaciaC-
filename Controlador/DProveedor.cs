using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using System.Windows.Forms;


namespace Controlador
{
    public class DProveedor : InterfDao
    {
        SqlConnection con;


        public DataTable getCombobox(object cod)
        {
            DataTable tb = new DataTable();
            string query = "SELECT ID_PROV,NOM_PROV FROM PROVEEDOR";
            SqlCommand cmd = new SqlCommand(query,Conexion.getCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            return tb;
        }
        public void add(Proveedor obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "INSERT INTO PROVEEDOR VALUES (" + "'"+obj.getCod+"',"+"'"+obj.getNom+"')";
            SqlCommand cmd = new SqlCommand(query,con);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos Registrados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ERROR NO SE REGISTRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            con.Close();
        }
        public void refresh(Proveedor obj)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "UPDATE PROVEEDOR SET "
                            + "NOM_PROV='" + obj.getNom + "'"
                            + " WHERE ID_PROV='" + obj.getCod + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Datos Actualizado");
            else
                MessageBox.Show("No se puedo Actualizar");
            con.Close();
        }

        public void add(Distrito obj)
        {
            throw new NotImplementedException();
        }

       
        public void delete(object cod)
        {
            con = Conexion.getCon();
            con.Open();
            string query = "Delete From Proveedor Where ID_PROV='"+ cod +"' ";
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
            string query = "SELECT * FROM PROVEEDOR";
            SqlCommand cmd = new SqlCommand(query, Conexion.getCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
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
