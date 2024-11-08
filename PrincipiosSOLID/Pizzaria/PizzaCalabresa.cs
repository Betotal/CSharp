using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        {
            
        }
        public override int PizzaAssar()
        {
            int tempo = 25;
            System.Console.WriteLine($"Tempo para Pizza de {Nome} ficar pronta: {tempo} minutos");
            return tempo;
        }
    }
}