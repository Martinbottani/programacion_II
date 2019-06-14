using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class frmPrincipal : Form
    {
        FormTestDelegados formito = new FormTestDelegados();
        FormMostrar mostrarsito = new FormMostrar();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formito.MdiParent = this;
            formito.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarsito.MdiParent = this;
            formito.EventoStrig += mostrarsito.ActualizarNombre;
            mostrarsito.Show();
        }

        private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if(mostrarToolStripMenuItem.Enabled == false)
            {
                mostrarToolStripMenuItem.Enabled = true;
            }
            else
            {
                mostrarToolStripMenuItem.Enabled = false;
            }
        }
    }
}
