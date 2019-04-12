using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 23";
            Dolar dolar1 = new Dolar(100);
            Pesos peso1 = new Pesos(100);
            Euro euro1 = new Euro(100);
            Euro euro2 = new Euro(0);
            Pesos peso2 = new Pesos(0);
            Dolar dolar2 = new Dolar(0);
            euro2 = (Euro)peso1;
            peso2 = (Pesos)euro1;
            dolar2 = (Dolar)peso1;
            Console.WriteLine("{0}", euro2.GetCantidad());
            Console.WriteLine("{0}", peso2.GetCantidad());
            Console.WriteLine("{0}", dolar2.GetCantidad());
            Console.ReadKey();
        }
    }
}
