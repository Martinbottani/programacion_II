using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }

        private string SetNumero
        {
            set { numero = ValidarNumero(value); }
        }

        public static double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            int i;
            bool flag = true;
            for(i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] < '0' || strNumero[i] > '9')
                {
                    retorno = 0;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                double.TryParse(strNumero, out retorno);
            }
            return retorno;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero + n2.numero;
            return result;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero - n2.numero;
            return result;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero * n2.numero;
            return result;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double result;
            result = n1.numero / n2.numero;
            return result;
        }
    }
}

