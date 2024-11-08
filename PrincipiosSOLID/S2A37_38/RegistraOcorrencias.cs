using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A37_38
{
    public class RegistraOcorrencias{
        private readonly IRegistro _registro;
        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }
        public void Registrar(string mensagem){
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
        
    }
}