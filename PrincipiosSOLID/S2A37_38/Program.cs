namespace S2A37_38
{
    public class Program_A37
    {
        public static void Main(){ // (string[] args)
            System.Console.Clear();
            System.Console.WriteLine("Fortemente acoplada");
            System.Console.WriteLine();
            RegistraOcorrencia registraOco = new();

            registraOco.RegistraConsole("Registro no Console.");
            registraOco.RegistraArquivo(@"D:\Curso\CSharp\PrincipiosSOLID\S2A37_38\S2A37_38.txt", "Registro no arquivo");
        
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Usando Interface");
            System.Console.WriteLine();

            var RegistraNoConsole = new RegistraOcorrencias(new RegistraConsole());
            RegistraNoConsole.Registrar("Registro no Console");

            var RegistraNoArquivo = new RegistraOcorrencias(new RegistraArquivo(@"D:\Curso\CSharp\PrincipiosSOLID\S2A37_38\S2A37_38.txt"));
            RegistraNoArquivo.Registrar("Registra no Arquivo");

            Console.ReadLine();
        }
    }
}