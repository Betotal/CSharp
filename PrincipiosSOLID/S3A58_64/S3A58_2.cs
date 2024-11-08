namespace S3A58_64{
    public class GeradorDesconto_2 { // Nomencaltura
        public decimal CalcularDesconto(decimal valorOriginal, int tipoCliente, int tempoFidelidade)
        {
            decimal valorFinal = 0;
            decimal descontoFidelidade = (tempoFidelidade > 5) ? (decimal)5 / 100 : (decimal)tempoFidelidade / 100;
            if (tipoCliente == 1)
            {
                valorFinal = valorOriginal;
            }
            else if (tipoCliente == 2)
            {
                valorFinal = (valorOriginal - (0.1m * valorOriginal)) 
                           - descontoFidelidade * (valorOriginal - (0.1m * valorOriginal));
            }
            else if (tipoCliente == 3)
            {
                valorFinal = (0.7m * valorOriginal) - descontoFidelidade * (0.7m * valorOriginal);
            }
            else if (tipoCliente == 4)
            {
                valorFinal = (valorOriginal - (0.5m * valorOriginal)) 
                           - descontoFidelidade * (valorOriginal - (0.5m * valorOriginal));
            }
            return valorFinal;
        }
    }
}
