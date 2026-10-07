using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class TrianguloRetangulo : Forma {
        private double _base, _altura;

        public TrianguloRetangulo(double baseTriangulo, double alturaTriangulo) : base ("Triângulo Retângulo") {
            _base = baseTriangulo;
            _altura = alturaTriangulo;
        }

        public override double Area() {

            return (_base * _altura) / 2;
        }

        public override double Perimetro() {

            double hipotenusa = Math.Sqrt((_base * _base) + (_altura * _altura));
            return _base + _altura + hipotenusa;
        }
    }
}
