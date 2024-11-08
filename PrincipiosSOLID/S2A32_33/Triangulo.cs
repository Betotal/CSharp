using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace S2A32_33
{
    public class Triangulo : Forma
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public override void CalcularArea()
        {
            this.Area = (Altura * Base) / 2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Base, 2)) + Altura + Base;
        }
    }
}