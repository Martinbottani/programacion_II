using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralHerencia;
namespace FormCentralTelefonica
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public Centralita centralita = new Centralita("Telecom");

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador nuevaLlamada = new FrmLlamador(centralita);
            nuevaLlamada.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void btnLocal_Click(object sender, EventArgs e)
        {

        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
