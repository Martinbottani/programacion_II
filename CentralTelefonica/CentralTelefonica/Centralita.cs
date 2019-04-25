using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;
            if (tipo == TipoLlamada.Local)
            {
               foreach(Llamada llamada in listaDeLlamadas)
               {
                    if(llamada is Local)
                    {
                        Local local = (Local)llamada;
                        retorno += local.CostoLlamada;
                    }                    
               }
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                foreach (Provincial provincia in listaDeLlamadas)
                {
                    retorno = provincia.CostoLlamada;
                }
            }
            else if (tipo == TipoLlamada.Todas)
            {

            }
           
            return retorno;
        }
    }
}
