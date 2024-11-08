using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace S1A19
{
    public class Heranca
    {
        static void Main(string[] args){
            Console.Clear();
            Carro carro = new();
            Console.WriteLine();
            Carro carro1 = new("qwerqwerqwerqwre78979");
            carro1.Teste();
            Console.ReadLine();   
            Console.Clear();
            Motocicleta moto = new(); 
            Console.WriteLine();
            Motocicleta moto1 = new("nmvmv,mb,mb,mb,mnb97987987987"); 
            moto1.Teste();
            Console.ReadLine();
        }
    }

//  Conta
/*
    class Conta{
        public int Numero{get; set;}
        public double Saldo { get; set; }

        public Conta()
        {
            Console.WriteLine("Construtor da classe Base!");
        }

    //    protected virtual void GetSaldo(){
        protected void GetSaldo(){
            Console.WriteLine("Saldo: 99,99");
        }
    }

    class ContaPoupanca:Conta{
        public int JurosMensais { get; set; }

    //    protected override void GetSaldo(){   // Sobrescrever necessita do Virtual na classe base
        protected new void GetSaldo(){   // Oculta o método da classe base
             Console.WriteLine("Saldo: 223,22");
        }
        public static void Main(string [] args){
            ContaPoupanca contap = new();
            contap.Numero = 100;
            contap.Saldo = 11.11;
            contap.GetSaldo();

            Console.ReadLine();
        }
    }
    */
//  Carro 
    public class Veiculo{

        private string numeroChassi;
        public Veiculo(string NumeroChassi){
            numeroChassi = NumeroChassi;
            Console.WriteLine($"Inicailizando Veículo: {NumeroChassi}");
        }
        public Veiculo(){
            Console.WriteLine("Inicializando Veiculo");
        }
        public virtual void Teste(){
            System.Console.WriteLine("Acessei Veículo");
        }
    }

    public class Carro: Veiculo{

        public Carro(string numeroChassi) : base(numeroChassi){
            // pode inicializar outros campos
            Console.WriteLine($"Inicailizando carro: {numeroChassi}");
        }
        public Carro(){
            Console.WriteLine("Inicializando Carro");
        }
        public override void Teste(){
            base.Teste();
            System.Console.WriteLine("Sobrescrevi Veículo >> Carro");
        }

    }

    public class Motocicleta: Veiculo{
        public Motocicleta(string numeroChassi) : base(numeroChassi){
            // pode inicializar outros campos
            Console.WriteLine($"Inicailizando Motocicleta: {numeroChassi}");
        }
        public Motocicleta(){
            Console.WriteLine("Inicializando Motocicleta");
        }
         public override void Teste(){
            base.Teste();
            System.Console.WriteLine("Sobrescrevi Veículo >> Motocicleta");
        }
   }


}