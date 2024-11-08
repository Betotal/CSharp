using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A32_33
{
    public abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        // metodos abstratos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        // método concreto
        public string Descricao()
        {
            return "Sou a classe Forma.";
        }

    }
}