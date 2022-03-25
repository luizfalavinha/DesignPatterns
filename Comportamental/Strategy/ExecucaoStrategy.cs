using System;
using System.Collections.Generic;

namespace DesignPatterns.Comportamental.Strategy
{
    public class ExecucaoStrategy
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{Nome = "Camisa Corinthians", Valor = new Random().Next(500)},
                new Produto{Nome = "Raquete Tenis", Valor = new Random().Next(500)}
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var meioPagamentoBoleto = new Pagamento
            {
                MeioPagamento = MeioPagamento.BoletoBancario
            };

            var meioPagamentoTransferencia = new Pagamento
            {
                MeioPagamento = MeioPagamento.Transferencia,
            };

            var pedidoBoleto = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoBoleto.MeioPagamento));
            var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, meioPagamentoBoleto);
            Console.WriteLine(pagamentoBoleto.Status);

            Console.WriteLine("------------------------------------------------------------------");

            var pedidoTransferencia = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoTransferencia.MeioPagamento));
            var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(pedido, meioPagamentoTransferencia);
            Console.WriteLine(pagamentoTransferencia.Status);
        }
    }
}