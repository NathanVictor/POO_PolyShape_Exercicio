using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class TrianguloRetangulo
    {

        private double _base, _altura;

        public double Area()
        {
            return (_base + _altura) / 2;
        }

        public double Perimetro()
        {
            double hipotenusa = Math.Sqrt((_base * _base) + (_altura * _altura));

            return _base + _altura + hipotenusa;
        }


    }
}
