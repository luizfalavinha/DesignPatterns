using System;

namespace DesignPatterns.Comportamental.Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioPagamento.Transferencia:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());

                case MeioPagamento.BoletoBancario:
                    return new PagamentoBoletoService(new PagamentoBoletoFacade());

                default:
                    throw new ApplicationException("Meio de Pagamento não conhecido");
            }
        }
    }
}