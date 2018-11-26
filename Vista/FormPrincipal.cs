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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Modulo.frmPro.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Modulo.frmProv.ShowDialog();
        }

        private void btnDistrito_Click(object sender, EventArgs e)
        {
            Modulo.frmDis.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Modulo.frmCat.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void tbnRegEntra_Click(object sender, EventArgs e)
        {
            Modulo.frmEntra.ShowDialog();
        }

        private void btnRegSalida_Click(object sender, EventArgs e)
        {
            Modulo.frmSal.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
