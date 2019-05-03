using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                if(patente.Length == 6)
                {
                    this.patente = value;
                }          
            }
        }

        public Vehiculo(string patente)
        {
            Patente = patente;
            ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(this.ToString());
            mostrar.AppendFormat("\nIngreso: {0}", ingreso);
            return mostrar.ToString();
        }

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("\nPatente {0}", Patente);
            return mostrar.ToString();
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if(v1.Equals(v2) && v1.Patente != v2.Patente)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 != v2);
        }
    }
}
