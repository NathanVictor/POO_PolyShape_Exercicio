using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class PoligonoReto : Forma
    {
        protected double _base;
        protected double _altura;

        public PoligonoReto(string descricao, double baseReto, double alturaReto) : base (descricao)
        {
            _base = baseReto;
            _altura = alturaReto;
        }
    }
}