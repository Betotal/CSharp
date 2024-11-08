using System;

namespace S1A22
{
    class Program{
        static void Main(string[] args)
        {
            //    upCasting();
            System.Console.WriteLine();
            //    downCasting();
            //    downCastingAS();
            Circulo circulo = new Circulo();
            Forma f = circulo; 
            
            if (f is Circulo){
                ((Circulo)f).PintarCirculo();
            }else{
                Console.WriteLine("A conversão não é possível");
            }

            Console.ReadLine();

        }

        private static void downCastingAS()
        {
            Forma f = new();
            Circulo c = f as Circulo;
            if (c != null)
            {
                c.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
        }

        private static void downCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;
            Circulo c = (Circulo)f; // downcasting   converte classe geral (base), 
                                    //               para classe especifica (filha)

            Console.WriteLine(c == f);
            Console.WriteLine(f == circulo);

            c.Desenhar();
            c.PintarCirculo();
        }

        private static void upCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;           // upcasting   converte classe especifica (filha), 
                                         //             para classe geral (base)

            Console.WriteLine(f == circulo);

            f.Desenhar();
        }
    }
}