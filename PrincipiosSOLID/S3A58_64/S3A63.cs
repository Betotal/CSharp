namespace S3A58_64
{
    public class GeradorDesconto_6 {  // Interface - Injeção de dependencia, com inversão de dependencia

        private readonly IDescontoFidelidade descontoFidelidade;
        private readonly IDescontoTipoClienteFabrica descontoTipoCliente;

        public GeradorDesconto_6(IDescontoFidelidade _descontoFidelidade, IDescontoTipoClienteFabrica _descontoTipoCliente)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoTipoCliente = _descontoTipoCliente;
            
        }
        public decimal CalcularDesconto(decimal valorOriginal, ClienteTipo tipoCliente, int tempoFidelidade)
        {
            decimal valorFinal = 0;
    //        decimal descontoFidelidade = (tempoFidelidade > Constantes.TempoFidelidade) ? (decimal)Constantes.TempoFidelidade / 100 : (decimal)tempoFidelidade / 100;

            valorFinal = descontoTipoCliente.GetDescontoTipoCliente(tipoCliente).AplicarDescontoTipoCliente(valorOriginal); 
            valorFinal = descontoFidelidade.AplicarDescontoFidelidade(valorFinal, tempoFidelidade);
        
            return valorFinal;
        }
    }
}
