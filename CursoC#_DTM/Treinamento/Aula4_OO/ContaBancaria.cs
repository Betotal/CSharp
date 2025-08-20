using System;

namespace Aula4_OO
{
    public class ContaBancaria
    {
        private string numeroConta;
        private string titular;
        private float saldo;

        public ContaBancaria(string numeroConta, string titular, float saldo)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Exibir()
        {
            Console.WriteLine($"\nConta: {numeroConta}");
            Console.WriteLine($"titular: {titular}");
            Console.WriteLine($"Saldo: {saldo:F2}");
        }

        public string Depositar(float valor)
        {
            saldo += valor;

            return $"\n       Deposito efetuado com sucesso. Novo saldo: {saldo:F2}";

        }

        public string Sacar(float valor)
        {
            if (saldo >= valor) 
            {
                saldo -= valor;
                return $"\n       Saque efetuado com sucesso. Novo saldo: {saldo:F2}";
            }
            else
            {
                return "\n       Saldo insuficiente para saque.";
            } 
        }
    }
}
