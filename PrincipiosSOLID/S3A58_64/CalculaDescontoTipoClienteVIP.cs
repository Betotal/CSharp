using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3A58_64
{
    public class CalculaDescontoTipoClienteVIP : IDescontoTipoCliente
    {
        public decimal AplicarDescontoTipoCliente(decimal preco)
        {
            return preco - (Constantes.FidelidadeVIP * preco);
        }
    }
}