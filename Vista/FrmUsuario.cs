using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                tipo = 'G';
                btnGua.Enabled = true;
                btnGua.Text = "Guardar";
                MHabilitarText(true);
                MClear();
                txtcod.Focus();
            }


        public void MHabilitarText(bool t)
        {
            txtcod.Enabled = t;
            txtnom.Enabled = t;
            txtape.Enabled = t;
            txtedad.Enabled = t;
        }
        public void MClear()
        {
            txtcod.Clear();
            txtnom.Clear();
            txtape.Clear();
            txtedad.Clear();
        }
    }
    }

