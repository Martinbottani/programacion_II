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
    public partial class FrmLlamador : Form
    {
        public FrmLlamador()
        {
            InitializeComponent();
        }

        public Centralita centralita;

        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            /*
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);*/
        }
    }
}
