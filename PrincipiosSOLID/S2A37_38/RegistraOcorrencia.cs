using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace S2A37_38
{
    public class RegistraOcorrencia
    {
        public void RegistraConsole(string mensagem)
        {
            System.Console.WriteLine($"{mensagem} : {DateTime.Now}");
        }
        public void RegistraArquivo(string arquivo, string mensagem)
        {
            using (var streamWriter = new StreamWriter(arquivo, true))
            {
                streamWriter.WriteLine($"{mensagem} : {DateTime.Now}");
            }
        }
        public void RegistraJSON(string arquivo, string mensagem)
        {

        }
    }
}