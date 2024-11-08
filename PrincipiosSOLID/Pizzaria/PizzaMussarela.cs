using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        {
            
        }
        public override int PizzaAssar()
        {
            int tempo = 15;
            System.Console.WriteLine($"Tempo para Pizza de {Nome} ficar pronta: {tempo} minutos");
            return tempo;
        }
    }
}