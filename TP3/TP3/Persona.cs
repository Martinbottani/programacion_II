using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        public abstract string Apellido
        {
            get;
            set;
        }

        public abstract int DNI
        {
            get;
            set;
        }

        public abstract ENacionalidad Nacionalidad
        {
            get;
            set;
        }

        public abstract string Nombre
        {
            get;
            set;
        }

        public abstract string StringToDNI
        {
            set;
        }
    }
}
