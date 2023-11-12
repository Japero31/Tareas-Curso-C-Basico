using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones.Clases
{
    public class Operadores
    {
        private int valor1;
        private int valor2;

        public void CargarValores(int a, int b)
        {
            valor1 = a;
            valor2 = b;
        }

        public int Suma()
        {
            return valor1 + valor2;
        }

        public int Resta()
        {
            return valor1 - valor2;
        }

        public int Producto()
        {
            return valor1 * valor2;
        }

        public double Division()
        {
            if (valor2 != 0)
            {
                return (double)valor2 / valor1;
            }
            else
            {
                throw new InvalidOperationException("No es posible dividir entre cero.");
            }
        }

    } 
}
