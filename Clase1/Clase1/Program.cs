using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 1";
      int num = 0;
      int i;
      string numero;
      bool numeroEnt;
      int min = int.MaxValue;
      int max = int.MinValue;
      int valor;
      float promedio = 0;
      for(i = 0; i < 5; i++)
      {
        Console.Write("Escriba 5 numeros: ");
        numero = Console.ReadLine();
        numeroEnt = int.TryParse(numero, out valor);
        num = valor;
        Console.WriteLine("El numero ingresado es: {0}\n", num);
        if(min > num)
        {
          min = num;
        }
        if(max < num)
        {
          max = num;
        }
        promedio += num;
      }
      promedio = promedio / 5;
      Console.WriteLine("El numero mayor es: {0}\n", max);
      Console.WriteLine("El numero menor es: {0}\n", min);
      Console.WriteLine("El promedio es: {0}\n", promedio);
      Console.ReadKey();
    }
  }
}
