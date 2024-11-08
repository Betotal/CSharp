using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A37_38
{
    public class RegistraConsole: IRegistro
    {
        public void RegistraInfo(string mensagem){
            System.Console.WriteLine($"info: {mensagem}");
        }
        
    }
}