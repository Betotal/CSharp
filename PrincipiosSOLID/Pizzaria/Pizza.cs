using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public Pizza(string nome)
        {
            Nome = nome; 
        }
        public abstract int PizzaAssar();
        public void PizzaEntrega(){
            System.Console.WriteLine($"Pizza {Nome} saiu para entrega");
        }
    
    }
}