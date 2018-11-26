using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;



namespace Vista
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        DCategoria obj = new DCategoria();
        char tipo = ' ';


        private void Form5_Load(object sender, EventArgs e)
        {
           

        }

        private void pentidad()
        {
            dataGridView1.DataSource = obj.getCargarLista("");
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            pentidad();
            
            mbotones(true);
            MHabilitartext(false);


        }
        private void btnnuev_Click(object sender, EventArgs e)
        {
            tipo = 'G';
            btnGuardar.Enabled = true;
            btnGuardar.Text = "Guardar";
            MHabilitarText(true);
            MClear();
            txtcod.Focus();
            txtcod.Enabled = true;
        }

        private void btnGua_Click(object sender, EventArgs e)
        {
            string cod = txtcod.Text.Trim();
            string nom = txtnom.Text.Trim();
            string des = txtDesc.Text.Trim();

            if (tipo == 'G') obj.add(new Categoria(cod, nom,des));
            else if (tipo == 'A') obj.refresh(new Categoria(cod, nom,des));

            mlimpiar();
            Form5_Load(null, null);
            pentidad();
        }

        public void MHabilitartext(bool t)
        {
            txtcod.Enabled = t;
            txtnom.Enabled = t;
            txtDesc.Enabled = t;
        }
        public void mlimpiar()
        {
            txtcod.Clear();
            txtnom.Clear();
            txtDesc.Clear();
        }
        private void btneli_Click(object sender, EventArgs e)
        {
            int f = dataGridView1.CurrentRow.Index;
            string col = dataGridView1.Rows[f].Cells[0].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                obj.delete(col);
                Form5_Load(null, null);
            }

            pentidad();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            tipo = 'A';
            btnGuardar.Text = "Actualizar";
            txtcod.Focus();
            MHabilitarText(true);
            btnGuardar.Enabled = true;

        }

       
        public void MHabilitarText(bool t)
        {
            btnGuardar.Enabled = txtnom.Enabled= txtDesc.Enabled=t;
        }
        public void MClear()
        {
            txtcod.Clear();
            txtnom.Clear();
            txtDesc.Clear();
        
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulo.frmPro.Form4_Load(null, null);
        }
        public void mbotones(bool b)
        {
            btnNuevo.Enabled = b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = b;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //int f = dataGridView1.CurrentRow.Index;
            //string cod = dataGridView1.Rows[f].Cells[0].Value.ToString(); //Extraer codigo
            //string nom = dataGridView1.Rows[f].Cells[1].Value.ToString(); //Extraer nombre
            //string des = dataGridView1.Rows[f].Cells[2].Value.ToString(); //Extraer descripcion

            //// DateTime fec = Convert.ToDateTime(dataGridView1.Rows[f].Cells[3].Value.ToString());
            ////string emp = dataGridView1.Rows[f].Cells[4].Value.ToString();
            //// string rub = dataGridView1.Rows[f].Cells[5].Value.ToString();

            //txtcod.Text = cod;
            //txtnom.Text = nom;
            //txtDesc.Text = des;


            //mbotones(true);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridView1.CurrentRow.Index;
            string cod = dataGridView1.Rows[f].Cells[0].Value.ToString(); //Extraer codigo
            string nom = dataGridView1.Rows[f].Cells[1].Value.ToString(); //Extraer nombre
            string des = dataGridView1.Rows[f].Cells[2].Value.ToString(); //Extraer descripcion

            // DateTime fec = Convert.ToDateTime(dataGridView1.Rows[f].Cells[3].Value.ToString());
            //string emp = dataGridView1.Rows[f].Cells[4].Value.ToString();
            // string rub = dataGridView1.Rows[f].Cells[5].Value.ToString();

            txtcod.Text = cod;
            txtnom.Text = nom;
            txtDesc.Text = des;
        

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int f = dataGridView1.CurrentRow.Index;
            string cod = dataGridView1.Rows[f].Cells[0].Value.ToString(); //Extraer codigo
            string nom = dataGridView1.Rows[f].Cells[1].Value.ToString(); //Extraer nombre
            string des = dataGridView1.Rows[f].Cells[2].Value.ToString(); //Extraer descripcion

            // DateTime fec = Convert.ToDateTime(dataGridView1.Rows[f].Cells[3].Value.ToString());
            //string emp = dataGridView1.Rows[f].Cells[4].Value.ToString();
            // string rub = dataGridView1.Rows[f].Cells[5].Value.ToString();

            txtcod.Text = cod;
            txtnom.Text = nom;
            txtDesc.Text = des;


            mbotones(true);
        }
    }
}
