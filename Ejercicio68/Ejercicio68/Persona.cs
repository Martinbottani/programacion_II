using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;
        public event DelegadoString EventoStrig;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public Persona()
        {
            
        }

        public string Mostrar()
        {
            return String.Format("Nombre de la persona: {0}\nApellido de la persona: {1}", Nombre, Apellido).ToString();
        }

    }
}
