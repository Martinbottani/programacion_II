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
            int i = 0;
            int j;
            int suma;
            int contadorPerfecto = 0;
            do
            {
                i++;
                suma = 0;
                for(j=1; j<i; j++)
                {
                    if(i % j == 0)
                    {
                        suma += j;
                    }
                }
                if(suma == i)
                {
                    Console.WriteLine("El numero perfecto es {0}", suma);
                    contadorPerfecto++;
                }
            } while (contadorPerfecto != 4);
            Console.ReadKey();
        }
    }
}
