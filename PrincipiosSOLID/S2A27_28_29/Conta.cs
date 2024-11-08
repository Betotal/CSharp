using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double Sacar(double valorSaque)
        {
            return Saldo - valorSaque;
        }
        public double Depositar(double valorDeposito)
        {
            return Saldo + valorDeposito;
        }

    }
}