using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private Entidades.DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new Entidades.DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numDNI.Value, (int)numExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(dt == null)
            {
                MessageBox.Show("Aun no se ha creado el DT!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!dt.ValidarAptitud())
            {
                MessageBox.Show("El DT no es apto!", "DT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
