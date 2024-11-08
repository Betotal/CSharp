using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args){
    //        Pizzaria p1 = new Pizzaria(new PizzaFabrica());
            Pizzaria p1 = new();
            p1.criarPizza("Mussarela");
            p1.criarPizza("Calabresa");

            Console.ReadLine();
        }
    }
}
