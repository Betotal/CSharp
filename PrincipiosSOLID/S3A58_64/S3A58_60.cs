namespace S3A58_64
{
    public class GeradorDesconto_3 { //Enum, Formula, CONTANTES
        public decimal CalcularDesconto(decimal valorOriginal, ClienteTipo tipoCliente, int tempoFidelidade)
        {
            decimal valorFinal = 0;
            decimal descontoFidelidade = (tempoFidelidade > Constantes.TempoFidelidade) ? (decimal)Constantes.TempoFidelidade / 100 : (decimal)tempoFidelidade / 100;

            switch (tipoCliente)
            {
                case ClienteTipo.TipoNaoCliente:   
                    valorFinal = valorOriginal;
                    break;

                case ClienteTipo.TipoClienteComum:
                    valorFinal = valorOriginal - (Constantes.FidelidadeCOMUM * valorOriginal);
                    valorFinal -= (descontoFidelidade * valorFinal);
                    break;           

                case ClienteTipo.TipoClienteEspecial:
                    valorFinal = valorOriginal - (Constantes.FidelidadeESPECIAL * valorOriginal); 
                    valorFinal -= (descontoFidelidade * valorFinal);
                    break;

                case ClienteTipo.TipoClienteVip:
                    valorFinal = valorOriginal - (Constantes.FidelidadeVIP * valorOriginal);
                    valorFinal -= (descontoFidelidade * valorFinal);
                    break;    

                default:
                    throw new NotImplementedException();    // OPÇÃO NAO IMPLEMENTADA
                //    break;           
            }
            return valorFinal;
        }
    }
}
