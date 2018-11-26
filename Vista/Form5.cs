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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        DCategoria obj = new DCategoria();
        char tipo = ' ';


        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.getCargarLista("");
            btnGua.Enabled = false;
            btnedit.Enabled = false;
            MHabilitarText(false);
        }

        private void btnnuev_Click(object sender, EventArgs e)
        {
            tipo = 'G';
            btnGua.Enabled = true;
            btnGua.Text = "Guardar";
            MHabilitarText(true);
            MClear();
            txtcod.Focus();
            txtcod.Enabled = false;
        }

        private void btnGua_Click(object sender, EventArgs e)
        {
            int cod = 0;
            string nom = txtnom.Text;

            if (tipo == 'G') obj.add(new Categoria(cod, nom));
            else if (tipo == 'A')
            {
                cod = int.Parse(txtcod.Text);
                obj.refresh(new Categoria(cod, nom));
            }
            Form5_Load(null, null);
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
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            tipo = 'A';
            btnGua.Text = "Actualizar";
            txtcod.Focus();
            MHabilitarText(true);
            btnGua.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridView1.CurrentRow.Index;
            string cod = dataGridView1.Rows[f].Cells[0].Value.ToString(); //Extraer codigo
            string nom = dataGridView1.Rows[f].Cells[1].Value.ToString(); //Extraer nombre

            txtcod.Text = cod;
            txtnom.Text = nom;

            btnedit.Enabled = true;
        }
        public void MHabilitarText(bool t)
        {
            txtcod.Enabled = t;
            txtnom.Enabled = t;
        }
        public void MClear()
        {
            txtcod.Clear();
            txtnom.Clear();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulo.frm4.Form4_Load(null, null);
        }

        private void txtbus_TextChanged(object sender, EventArgs e)
        {
            object bus = txtbus.Text;
            dataGridView1.DataSource = obj.getCargarLista(bus);
        }
    }
}
