using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A30_31
{
    public class Homem
    {
        Animal homem = new Animal();
        ComportamentoAndar Andar = new ComportamentoAndar();

        public void FalaHomem()
        {
            System.Console.WriteLine("Ola ....");
        }

    }
}