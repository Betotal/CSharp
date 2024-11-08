using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A32_33
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override void CalcularArea()
        {
            this.Area = Math.PI * Math.Pow(Raio, 2);
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = Math.PI * 2 * Raio;
        }
    }
}