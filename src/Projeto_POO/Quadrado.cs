using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class Quadrado : Retangulo {
        public Quadrado(double lado) : base (lado, lado) {
            // Sobrescreve a descrição gerada pelo pai se preferir, ou ajusta o construtor
        }

        public override string ToString() {
            return $"Quadrado com área de {Area():F4}";
        }
    }
}