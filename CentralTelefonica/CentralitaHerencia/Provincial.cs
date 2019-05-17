using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            if(franjaHoraria == Franja.Franja_1)
            {
                retorno = base.Duracion * 0.99f;
            }
            else if(franjaHoraria == Franja.Franja_2)
            {
                retorno = base.Duracion * 1.25f;
            }
            else if(franjaHoraria == Franja.Franja_3)
            {
                retorno = base.Duracion * 0.66f;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("{0}\nSu costo de llamada es de: {1}\nLa franja horaria es de: {2}", base.Mostrar(), CostoLlamada, franjaHoraria);
            return mostrar.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
