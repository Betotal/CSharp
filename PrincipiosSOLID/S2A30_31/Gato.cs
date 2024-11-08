using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S2A30_31
{
    public class Gato
    {
        Animal gato = new Animal();
        ComportamentoAndar Andar = new ComportamentoAndar();

        public void FalaGato()
        {
            System.Console.WriteLine("Miau ....");
        }
    }
}