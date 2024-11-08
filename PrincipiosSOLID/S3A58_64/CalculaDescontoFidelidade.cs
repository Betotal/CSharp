using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace S3A58_64
{
    public class CalculaDescontoFidelidade : IDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoFidelidade){
            decimal descontoFidelidade = (tempoFidelidade >= Constantes.TempoFidelidade) ? 
                                         (decimal)Constantes.TempoFidelidade / 100 : (decimal)tempoFidelidade / 100;
            return preco - (descontoFidelidade * preco);
        }
    }
}