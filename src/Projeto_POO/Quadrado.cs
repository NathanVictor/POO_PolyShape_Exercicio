using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class Quadrado
    {
        private double _lado;

        public double Area()
        {
            return _lado * _lado;

        }

        public double Perimetro()
        {
            return 4 * _lado;
        }
    }
}
