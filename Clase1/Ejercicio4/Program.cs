using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";
            int i;
            //int j;
            string numero;
            bool numeroEnt;
            int valor;
            int contadorDivisores = 0;
            Console.Write("Escriba un numero: ");
            numero = Console.ReadLine();
            numeroEnt = int.TryParse(numero, out valor);
            if(valor != 0)
            {
                for(i = 1; i < valor; i++)
                {
                    if(valor / i == 0)
                    {
                        contadorDivisores += i;
                    }
                    if(contadorDivisores == valor)
                    {
                        Console.WriteLine("Numero divisor {0}", i);
                    }
                   
                }
            }
        }
    }
}
