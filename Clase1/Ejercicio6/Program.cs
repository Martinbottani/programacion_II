using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            int i;
            string numero;
            bool numeroEnt;
            string numero2;
            bool numeroEnt2;
            int valor;
            int valor2;
            Console.Write("Escriba un año: ");
            numero = Console.ReadLine();
            numeroEnt = int.TryParse(numero, out valor);
            Console.Write("Escriba el segundo año: ");
            numero2 = Console.ReadLine();
            numeroEnt2 = int.TryParse(numero2, out valor2);
            for(i = valor; i <= valor2; i++)
            {
                if(i%4 == 0 || i%400 == 0)
                {
                    Console.WriteLine("Entre el año {0} es bisiesto", i);
                }
            }
            Console.ReadKey();

        }
    }
}
