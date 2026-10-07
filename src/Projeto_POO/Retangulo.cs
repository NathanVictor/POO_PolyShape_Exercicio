using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class Retangulo : PoligonoReto {
        public Retangulo(double largura, double altura) : base("Retângulo", largura, altura) {
        }

        public override double Area() {
            return _base * _altura;
        }

        public override double Perimetro() {
            return 2 * (_base + _altura);
        }
    }
}