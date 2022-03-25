using Design_Patterns.AbstractFactory;
using Design_Patterns.Comportamental.Observer;
using DesignPatterns.Comportamental.Strategy;
using DesignPatterns.Estrutural.Adapter;
using DesignPatterns.Estrutural.Facade;
using FactoryMethod;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ID do pattern à executar:");

            Console.WriteLine("---------------- CRIACIONAL ------------------");
            Console.WriteLine("0 - Factory Method");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("");

            Console.WriteLine("---------------- ESTRUTURAL ------------------");
            Console.WriteLine("2 - Adapter");
            Console.WriteLine("3 - Facade");
            Console.WriteLine("");

            Console.WriteLine("---------------- COMPOTAMENTAL ------------------");
            Console.WriteLine("4 - Strategy");
            Console.WriteLine("5 - Observer");

            var id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoFactoryMethod.Executar();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoAbstractFactory.Executar();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoAdapter.Executar();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoFacade.Executar();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoStrategy.Executar(); // pode implementar com Facade
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("");
                    ExecucaoObserver.Executar();
                    break;
                default:
                    Console.WriteLine("Pattern não encontrado!");
                    break;
            }

        }
    }
}
