namespace DesignPatterns.Estrutural.Facade.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }

    public enum MeioPagamento
    {
        BoletoBancario = 0,
        CartaoCredito = 1
    }
}