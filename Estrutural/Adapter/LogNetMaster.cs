using System;

namespace DesignPatterns.Estrutural.Adapter
{
    // Adapte class
    public class LogNetMaster : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado - " + exception.Message);
        }
    }
}