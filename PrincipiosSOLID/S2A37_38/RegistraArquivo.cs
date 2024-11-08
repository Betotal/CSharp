using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A37_38
{
    public class RegistraArquivo : IRegistro{
        private readonly string _caminhoquivo;
        public RegistraArquivo(string path){
            _caminhoquivo = path;
        }
        public void RegistraInfo(string mensagem){
            log(mensagem);
        }

        private void log(string mensagem){
            using (var streamWriter = new StreamWriter(_caminhoquivo, true)){
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}