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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        DProducto obj = new DProducto();
        DCategoria obj2 = new DCategoria();
        char tipo = ' ';

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                Modulo.frm4 = this;
                dataGridView1.DataSource = obj.getCargarLista("");
                cbocat.DataSource = obj2.getCargarComboBox();
                cbocat.ValueMember = "NOM_CAT";
                btnGua.Enabled = false;
                btnedit.Enabled = false;
                MHabilitarText(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "ERROR :" + ex.Message.ToString(), "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnnuev_Click(object sender, EventArgs e)
        {
            tipo = 'G';
            btnGua.Enabled = true;
            btnGua.Text = "Guardar";
            MHabilitarText(true);
            MClear();
            txtcod.Focus();
        }

        private void btnGua_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtcod.Text;
                string nom = txtnom.Text;
                double pre = double.Parse(txtpre.Text);
                int sto = int.Parse(txtsto.Text);
                DateTime fechae = dateFechaE.Value;
                DateTime fechav = dateFechaV.Value;
                cbocat.ValueMember = "COD_CAT";
                int cat = int.Parse(cbocat.SelectedValue.ToString());
                if (tipo == 'G') obj.add(new Producto(cod, nom, pre,sto,fechae,fechav,cat));
                else if (tipo == 'A') obj.refresh(new Producto(cod, nom, pre, sto, fechae, fechav, cat));

                Form4_Load(null, null);
                MClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "ERROR :" + ex.Message.ToString(), "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            try
            {

                int f = dataGridView1.CurrentRow.Index;
                string col = dataGridView1.Rows[f].Cells[0].Value.ToString();
                if (MessageBox.Show("Deseas Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj.delete(col);
                    Form4_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "ERROR :" + ex.Message.ToString(), "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            string pre = dataGridView1.Rows[f].Cells[2].Value.ToString(); //Extraer apellido
            string sto = dataGridView1.Rows[f].Cells[3].Value.ToString(); //Extraer edad
            DateTime fece = Convert.ToDateTime(dataGridView1.Rows[f].Cells[4].Value.ToString());
            DateTime fecv = Convert.ToDateTime(dataGridView1.Rows[f].Cells[5].Value.ToString());
            string cat = dataGridView1.Rows[f].Cells[6].Value.ToString();

            txtcod.Text = cod;
            txtnom.Text = nom;
            txtpre.Text = pre;
            txtsto.Text = sto;
            dateFechaE.Value = fece;
            dateFechaV.Value = fecv;
            cbocat.SelectedItem = cat;

            btnedit.Enabled = true;
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            Modulo.frm5.ShowDialog();
        }
        public void MClear()
        {
            txtcod.Clear();
            txtnom.Clear();
            txtpre.Clear();
            txtsto.Clear();
            
        }
        public void MHabilitarText(bool t)
        {
            txtcod.Enabled = t;
            txtnom.Enabled = t;
            txtpre.Enabled = t;
            txtsto.Enabled = t;
        }

        private void txtbus_TextChanged(object sender, EventArgs e)
        {
            string bus = txtbus.Text;
            dataGridView1.DataSource = obj.getCargarLista(bus);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
