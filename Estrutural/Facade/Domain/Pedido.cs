using System;
using System.Collections.Generic;

namespace DesignPatterns.Estrutural.Facade.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}