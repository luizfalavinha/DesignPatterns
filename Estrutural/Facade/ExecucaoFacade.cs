using System;
using System.Collections.Generic;
using DesignPatterns.Estrutural.Facade.CrossCutting;
using DesignPatterns.Estrutural.Facade.Domain;

namespace DesignPatterns.Estrutural.Facade
{
    public class ExecucaoFacade
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

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 3333 7777"
            };

            var pagamentoService = new PagamentoCartaoCreditoService(new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            Console.WriteLine(pagamentoResult.Status);
        }
    }
}