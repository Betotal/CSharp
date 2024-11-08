using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }
        public double CreditoJuros(double valorJuros)
        {
            return Saldo + valorJuros;
        }

    }
}