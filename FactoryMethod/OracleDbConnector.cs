using System;

namespace FactoryMethod
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectString) : base(connectString)
        {
            ConnectString = connectString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando no Oracle");
            var connection = new Connection(ConnectString);
            connection.Open();

            return connection;
        }
    }
}
