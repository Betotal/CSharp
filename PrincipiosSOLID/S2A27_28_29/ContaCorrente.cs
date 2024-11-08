using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class ContaCorrente : Conta
    {
        public double Limite { get; set; }
        public double DescontoJuros(double valorDesconto)
        {
            return Saldo - (valorDesconto * 0.1);
        }
    }
}