using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            int i;
            string numero;
            bool numeroEnt;
            int valor;
            int result1 = 0;
            int result2;
            int numeroIngresado;
            int auxiliar;
            Console.Write("Escriba un numero: ");
            numero = Console.ReadLine();
            numeroEnt = int.TryParse(numero, out valor);
            numeroIngresado = valor;
            for(i=1; i<valor; i++)
            {
                result1 = result1 + i;
            }
            result2 = valor + 1;
            auxiliar = valor + 1;
            do
            {
                auxiliar++;
                result2 = result2 + auxiliar;               
            } while (result2 < result1);
            if (result2 == result1)
            {
                Console.WriteLine("El numero {0} es un centro numerico\n", numeroIngresado);

            }
            Console.ReadKey();
        }
    }
}
