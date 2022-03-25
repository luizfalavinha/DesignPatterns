using System;
using System.Linq;

namespace DesignPatterns.Comportamental.Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public string GerarBoleto()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}