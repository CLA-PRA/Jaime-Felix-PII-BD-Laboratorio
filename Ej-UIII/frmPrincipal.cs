using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_UIII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Desea salir de la aplicación?","Salud Saludable",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.No)
                e.Cancel = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PONER LOS DATOS DEL AUTOR AQUI", "Salud Saludable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void estudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatEst catalogoEstudios = new frmCatEst();
            catalogoEstudios.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatPac catalgoPacientes = new frmCatPac();
            catalgoPacientes.ShowDialog();
        }

        private void ordenDeEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenes ordenes = new frmOrdenes();
            ordenes.ShowDialog();
        }
    }
}
