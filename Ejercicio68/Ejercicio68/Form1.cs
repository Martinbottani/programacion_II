using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString EventoString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona == null)
            {
                persona = new Persona();
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                EventoString.Invoke("Se ha creado la persona.");
                btnCrear.Text = "Actualizar";

            }
            else
            {
                if(persona.Nombre != txtNombre.Text || persona.Apellido != txtApellido.Text)
                {
                    persona.Nombre = txtNombre.Text;
                    persona.Apellido = txtApellido.Text;
                    EventoString.Invoke("Se ha modificado el nombre y/o el apellido.");
                }
            }
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventoString += NotificarCambio;
        }
    }
}
