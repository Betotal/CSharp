using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    public static class PizzaFabrica
    {
        public static Pizza PizzaCriar(string tipo){
            Pizza pizza = null;
            if(tipo.Equals("Mussarela")){
                pizza = new PizzaMussarela(("Mussarela"));
            }
            else if (tipo.Equals("Calabresa")){
                pizza = new PizzaCalabresa("Calabresa");
            }
            return pizza;
        }
    
    }
}