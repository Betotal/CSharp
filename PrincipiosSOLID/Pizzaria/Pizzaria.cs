using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizzaria
    {
        // versão anterior
        /*
        private Pizza pizza;
        public void CriarPizza(string tipo)
        {
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela();
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa();
            }
        }
        */

        private Pizza pizza;
//        PizzaFabrica pizzaDo;
//        public Pizzaria(PizzaFabrica _pizzaDo)
//        {
//            pizzaDo = _pizzaDo;
//        }

        public void criarPizza(string tipo){
//            pizza = pizzaDo.PizzaCriar(tipo);
            pizza = PizzaFabrica.PizzaCriar(tipo);
            pizza.PizzaAssar();
            pizza.PizzaEntrega();

        }
    }
}