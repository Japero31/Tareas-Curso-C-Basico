using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadosTriangulo.Clases
{
    public class Equilatero
    {
        public bool SiEquilatero(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 && lado2 == lado3;
        }
    }
}
