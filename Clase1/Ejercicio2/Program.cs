using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 2";
      int num = 0;
      string numero;
      bool numeroEnt;
      int valor;
      Console.Write("Escriba un numero: ");
      numero = Console.ReadLine();
      numeroEnt = int.TryParse(numero, out valor);
      num = valor;
      if(valor != 0)
      {
        Console.WriteLine("{0}^{1} = {2}", num, 2, (int)Math.Pow(num, 2));
        Console.WriteLine("{0}^{1} = {2}", num, 3, (int)Math.Pow(num, 3));
      }    
      Console.ReadKey();
    }
  }
}
