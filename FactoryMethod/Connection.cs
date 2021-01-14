using System;

namespace FactoryMethod
{
    public class Connection
    {
        public string ConnectString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectstring)
        {
            ConnectString = connectstring;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando comando: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta!");
        }
        
        public void Close()
        {
            Console.WriteLine("Conexão fechada!");
        }
    }
}
