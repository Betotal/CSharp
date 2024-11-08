using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3A58_64
{
    public interface IDescontoTipoClienteFabrica
    {
        IDescontoTipoCliente GetDescontoTipoCliente(ClienteTipo clienteTipo);
    }
}