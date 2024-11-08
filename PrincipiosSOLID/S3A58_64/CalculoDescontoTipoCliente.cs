using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3A58_64
{
    public class CalculoDescontoTipoCliente : IDescontoTipoClienteFabrica
    {
        public IDescontoTipoCliente GetDescontoTipoCliente(ClienteTipo tipoCliente){

            IDescontoTipoCliente Calcular;
            switch (tipoCliente)
            {
                case ClienteTipo.TipoNaoCliente:   
                    Calcular = new CalculaDescontoTipoNaoCliente();
                    break;

                case ClienteTipo.TipoClienteComum:
                    Calcular = new CalculaDescontoTipoClienteCOMUM();
                    break;  

                case ClienteTipo.TipoClienteEspecial:
                    Calcular = new CalculaDescontoTipoClienteESPECIAL(); 
                    break;

                case ClienteTipo.TipoClienteVip:
                    Calcular = new CalculaDescontoTipoClienteVIP(); 
                    break;    

                default:
                    throw new NotImplementedException();    // OPÇÃO NAO IMPLEMENTADA
                //    break;           
            }
            return Calcular;

        }
    }
}