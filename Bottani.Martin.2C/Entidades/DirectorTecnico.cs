using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return añosExperiencia;
            }
            set
            {
                añosExperiencia = value;
            }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("*DIRECTOR TECNICO*\n\n{0}", base.Mostrar(), "\nAños de experiencia: {1}\n", AñosExperiencia);
            return mostrar.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(Edad < 65 && AñosExperiencia >= 2)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
