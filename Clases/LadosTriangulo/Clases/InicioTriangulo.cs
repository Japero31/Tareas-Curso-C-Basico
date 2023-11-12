using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadosTriangulo.Clases
{
    public class InicioTriangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public void IniciarTriangulo(double a, double b, double c)
        {
            lado1 = a;
            lado2 = b;
            lado3 = c;
        }
    }
}
