using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadosTriangulo.Clases
{
    public class LadoMayor
    {
        public double Calculo(double lado1, double lado2, double lado3)
        {
            return Math.Max(Math.Max(lado1, lado2), lado3);
        }
    }
}
