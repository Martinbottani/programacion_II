using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Conversor
{
    public partial class ConversorDinero : Form
    {
        public ConversorDinero()
        {
            InitializeComponent();
        }

        private void textEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            if(double.TryParse(txtEuro.Text, out cantidad))
            {
                Euro euro1 = new Euro(cantidad);
                Dolar dolar1 = new Dolar(0);
                Pesos peso1 = new Pesos(0);
                Euro euro2 = new Euro(0);

                euro2 = (Euro)euro1;
                dolar1 = (Dolar)euro1;
                peso1 = (Pesos)euro1;
                txtEuroADolar.Text = Convert.ToString(dolar1.GetCantidad());
                txtEuroAEuro.Text = Convert.ToString(euro2.GetCantidad());
                txtEuroAPesos.Text = Convert.ToString(peso1.GetCantidad());
            }
        }

        private void btnConverDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(txtDolar.Text, out cantidad))
            {
                Dolar dolar1 = new Dolar(cantidad);
                Euro euro1 = new Euro(0);
                Pesos peso1 = new Pesos(0);
                Dolar dolar2 = new Dolar(0);

                dolar2 = (Dolar)dolar1;
                euro1 = (Euro)dolar1;
                peso1 = (Pesos)dolar1;
                txtDolarADolar.Text = Convert.ToString(dolar2.GetCantidad());
                txtDolarAEuro.Text = Convert.ToString(euro1.GetCantidad());
                txtDolarAPesos.Text = Convert.ToString(peso1.GetCantidad());
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(txtPesos.Text, out cantidad))
            {
                Pesos peso1 = new Pesos(cantidad);
                Euro euro1 = new Euro(0);
                Dolar dolar1 = new Dolar(0);
                Pesos peso2 = new Pesos(0);

                peso2 = (Pesos)peso1;
                euro1 = (Euro)peso1;
                dolar1 = (Dolar)peso1;
                txtPesosADolar.Text = Convert.ToString(dolar1.GetCantidad());
                txtPesosAEuros.Text = Convert.ToString(euro1.GetCantidad());
                txtPesosAPesos.Text = Convert.ToString(peso2.GetCantidad());
            }
        }
    }
}
