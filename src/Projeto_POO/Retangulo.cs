using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class Retangulo
    {
        private double _base,_altura;

        public double Area()
        {
            return _base * _altura;

        }

        public double Perimetro()
        {
            return 2 * (_base + _altura);
        }

    }
}
