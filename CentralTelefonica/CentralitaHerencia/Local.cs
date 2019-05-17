using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return costo * base.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("{0}\nSu costo de llamada es de: {1}", base.Mostrar() , CostoLlamada);
            return mostrar.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
