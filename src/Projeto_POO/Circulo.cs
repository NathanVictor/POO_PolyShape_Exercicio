using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class Circulo
    {

        private double _raio;


        public double Area()
        {
            return Math.PI * _raio * _raio;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * _raio;
        }



    }
}
