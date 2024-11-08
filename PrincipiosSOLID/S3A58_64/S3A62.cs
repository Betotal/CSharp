namespace S3A58_64
{
    public class GeradorDesconto_5 {  // Interface - Injeção de dependencia, com inversão de dependencia

        private readonly IDescontoFidelidade descontoFidelidade;

        public GeradorDesconto_5(IDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
            
        }
        public decimal CalcularDesconto(decimal valorOriginal, ClienteTipo tipoCliente, int tempoFidelidade)
        {
            decimal valorFinal = 0;
    //        decimal descontoFidelidade = (tempoFidelidade > Constantes.TempoFidelidade) ? (decimal)Constantes.TempoFidelidade / 100 : (decimal)tempoFidelidade / 100;

            switch (tipoCliente)
            {
                case ClienteTipo.TipoNaoCliente:   
                    valorFinal = new CalculaDescontoTipoNaoCliente().AplicarDescontoTipoCliente(valorOriginal);
                    valorFinal = descontoFidelidade.AplicarDescontoFidelidade(valorFinal, tempoFidelidade);
                    break;

                case ClienteTipo.TipoClienteComum:
                    valorFinal = new CalculaDescontoTipoClienteCOMUM().AplicarDescontoTipoCliente(valorOriginal);
                    valorFinal = descontoFidelidade.AplicarDescontoFidelidade(valorFinal, tempoFidelidade);
                    break;           

                case ClienteTipo.TipoClienteEspecial:
                    valorFinal = new CalculaDescontoTipoClienteESPECIAL().AplicarDescontoTipoCliente(valorOriginal); 
                    valorFinal = descontoFidelidade.AplicarDescontoFidelidade(valorFinal, tempoFidelidade);
                    break;

                case ClienteTipo.TipoClienteVip:
                    valorFinal = new CalculaDescontoTipoClienteVIP().AplicarDescontoTipoCliente(valorOriginal); 
                    valorFinal = descontoFidelidade.AplicarDescontoFidelidade(valorFinal, tempoFidelidade);
                    break;    

                default:
                    throw new NotImplementedException();    // OPÇÃO NAO IMPLEMENTADA
                //    break;           
            }
            return valorFinal;
        }
    }
}
