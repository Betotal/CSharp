using System;

namespace S3A58_64
{
    public class Program_A64
    {
        public static void Main() //string[] args)
        {
            // gerDesc
            GerDesc gerDesc = new GerDesc();
            System.Console.Clear();
        
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%) - GerDesc\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = gerDesc.Calcular(1000, i, 10);
                Console.WriteLine($"Cliente tipo {i}, 10 anos fidelidade,  = {resultado}");
            }

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = gerDesc.Calcular(1000, i, 4);
                Console.WriteLine($"Cliente tipo {i} o valor do desconto é de : {resultado}");
            }  
            Console.ReadLine();

            // GeradorDesconto_2 
            GeradorDesconto_2 GeradorDesconto_2 = new GeradorDesconto_2();
            System.Console.Clear();
 
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%) -  - GeradorDesconto_2\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = GeradorDesconto_2.CalcularDesconto(1000, i, 10);
                Console.WriteLine($"Cliente tipo {i}, 10 anos fidelidade,  = {resultado}");
            }

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = GeradorDesconto_2.CalcularDesconto(1000, i, 4);
                Console.WriteLine($"Cliente tipo {i} o valor do desconto é de : {resultado}");
            }  
            Console.ReadLine();

            // GeradorDesconto_3 
            GeradorDesconto_3 GeradorDesconto_3 = new GeradorDesconto_3();
            System.Console.Clear();
 
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%) -  - GeradorDesconto_3\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = GeradorDesconto_3.CalcularDesconto(1000, (ClienteTipo)i, 10);
                Console.WriteLine($"Cliente tipo {i}, 10 anos fidelidade,  = {resultado}");
            }

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = GeradorDesconto_3.CalcularDesconto(1000, (ClienteTipo)i, 4);
                Console.WriteLine($"Cliente tipo {i} o valor do desconto é de : {resultado}");
            }  
            Console.ReadLine();

            // GeradorDesconto_6 
            IDescontoFidelidade descFidelidade = new CalculaDescontoFidelidade();
            IDescontoTipoClienteFabrica descClienteTipo = new CalculoDescontoTipoCliente();
            GeradorDesconto_6 geradorDesconto_6 = new GeradorDesconto_6(descFidelidade, descClienteTipo) ;
            System.Console.Clear();
 
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%) -  - GeradorDesconto_6\n");
            for (int i = 2; i < 5; i++)
            {   
                var resultado = geradorDesconto_6.CalcularDesconto(1000, (ClienteTipo)i , 10);
                Console.WriteLine($"Cliente tipo {i}, 10 anos fidelidade,  = {resultado}");
            }

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            for (int i = 2; i < 5; i++)
            {
                var resultado = geradorDesconto_6.CalcularDesconto(1000, (ClienteTipo)i, 4);
                Console.WriteLine($"Cliente tipo {i} o valor do desconto é de : {resultado}");
            }  
            Console.ReadLine();

        }
    }
}
