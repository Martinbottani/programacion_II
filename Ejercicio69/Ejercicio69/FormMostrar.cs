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
   
    public partial class FormMostrar : Form
    {
        public delegate void DelegadoString(string msg);
        public FormMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string dato)
        {
            lblEtiqueta.Text = dato;
        }
    }
}
