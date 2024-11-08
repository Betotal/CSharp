using System.Runtime.InteropServices;
namespace S2A32_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new();
            Triangulo t = new();
            Circulo c = new();

            Console.Clear();
            System.Console.WriteLine("Forma Geométrica");
            System.Console.WriteLine();
            System.Console.WriteLine("Quadrado");

            System.Console.Write("Informe a cor do Quadrado: ");
            q.Cor = Console.ReadLine();
            System.Console.Write("Informe a tamanho do lado do Quadrado: ");
            q.Lado = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            System.Console.WriteLine("Forma Geométrica");
            System.Console.WriteLine();
            System.Console.WriteLine("Triangulo");

            System.Console.Write("Informe a cor do Triangulo: ");
            t.Cor = Console.ReadLine();
            System.Console.Write("Informe a Altura do Triangulo: ");
            t.Altura = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Informe a tamanho do base do Triangulo: ");
            t.Base = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            System.Console.WriteLine("Forma Geométrica");
            System.Console.WriteLine();
            System.Console.WriteLine("Circulo");

            System.Console.Write("Informe a cor do Circulo: ");
            c.Cor = Console.ReadLine();
            System.Console.Write("Informe a tamanho do Raio do Circulo: ");
            c.Raio = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            t.CalcularArea();
            t.CalcularPerimetro();

            c.CalcularArea();
            c.CalcularPerimetro();

            Console.Clear();
            System.Console.WriteLine("Forma Geométrica");
            System.Console.WriteLine();
            System.Console.WriteLine($"Quadrado de cor: {q.Cor}, com tamanho {q.Lado}, com Perimetro {q.Perimetro} e Area {q.Area}. ");
            System.Console.WriteLine($"Triangulo de cor: {t.Cor}, com Altura {t.Altura} e base {t.Base}, com Perimetro {t.Perimetro} e Area {t.Area}. ");
            System.Console.WriteLine($"Circulo de cor: {c.Cor}, de Raio {c.Raio}, com Perimetro {c.Perimetro} e Area {c.Area}. ");

            Console.ReadLine();
        }
    }
}