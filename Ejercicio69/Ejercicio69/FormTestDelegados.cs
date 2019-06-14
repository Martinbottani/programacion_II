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
    public partial class FormTestDelegados : Form
    {
        public event FormMostrar.DelegadoString EventoStrig;
        public FormTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EventoStrig.Invoke(txtDatos.Text);
        }
    }
}
