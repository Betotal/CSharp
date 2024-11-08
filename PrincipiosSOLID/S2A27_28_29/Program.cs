using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new();
            cp.Saldo = cp.Depositar(100);
            cp.Saldo = cp.Sacar(10);
            System.Console.WriteLine($"Poupança: {cp.CreditoJuros(10)}");

            ContaCorrente cc = new();
            cc.Saldo = cc.Depositar(100);
            cc.Saldo = cc.Sacar(10);
            System.Console.WriteLine($"ContaCorrente: {cc.DescontoJuros(10)}");

        }
    }
}