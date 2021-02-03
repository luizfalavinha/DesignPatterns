using Design_Patterns.AbstractFactory.ConcreteFactory;
using System;

namespace Design_Patterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            ICelular nokiaPhone = new Nokia();
            CelularClient nokiaClient = new CelularClient(nokiaPhone);

            Console.WriteLine("********** NOKIA ***********");
            Console.WriteLine(nokiaClient.BuscarSmartphoneModeloDetalhe());
            Console.WriteLine(nokiaClient.BuscarNormalphoneModeloDetalhes());



            ICelular samsungPhone = new Samsung();
            CelularClient samsungClient = new CelularClient(samsungPhone);

            Console.WriteLine("********** SAMSUNG ***********");
            Console.WriteLine(samsungClient.BuscarSmartphoneModeloDetalhe());
            Console.WriteLine(samsungClient.BuscarNormalphoneModeloDetalhes());

            Console.ReadKey();
        }
    }
}
