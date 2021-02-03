using System;

namespace Design_Patterns.Comportamental.Observer
{
    public static class ExecucaoObserver
    {
        public static void Executar()
        {
            var joao = new Observador("João");
            var edu = new Observador("Edu");
            var caio = new Observador("Caio");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var microsoft = new PapelBovespa("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(edu);

            microsoft.Subscribe(edu);
            microsoft.Subscribe(caio);

            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                microsoft.Valor = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(edu);
                }
            }
        }


        // Método cria valor random
        public static decimal NextDecimal()
        {
            var random = new Random();
            var next = random.Next(141421, 314160);
            return next / (decimal) 100000.00;
        }
    }
}
