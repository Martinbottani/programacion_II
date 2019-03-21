using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int i;
            int j;
            string numero;
            bool numeroEnt;
            int valor;
            Console.Write("Escriba un numero: ");
            numero = Console.ReadLine();
            numeroEnt = int.TryParse(numero, out valor);
            int contadorPrimos = 0;
            if(valor != 0)
            {
                for(i = 1; i <= valor; i++)
                {
                    for(j = 1; j <= i; j++)
                    {
                        if((i % j) == 0 && contadorPrimos < 3)
                        {
                            contadorPrimos++;
                        }
                    }
                    if (contadorPrimos == 2)
                    {
                        Console.Write("El numero {0} es primo\n", i);
                    }
                    contadorPrimos = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
