using Design_Patterns.AbstractFactory;
using FactoryMethod;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ID do pattern à executar:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("0 - Factory Method");
            Console.WriteLine("1 - Abstract Factory");

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
                default:
                    Console.WriteLine("Pattern não encontrado!");
                    break;
            }

        }
    }
}
