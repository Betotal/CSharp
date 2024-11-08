using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A32_33
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Lado;
        }
    }
}