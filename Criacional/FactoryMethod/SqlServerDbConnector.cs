using System;

namespace FactoryMethod
{
    public class SqlServerDbConnector : DbConnector
    {
        public SqlServerDbConnector(string connectString) : base(connectString)
        {
            ConnectString = connectString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando no SQL Server");
            var connection = new Connection(ConnectString);
            connection.Open();

            return connection;
        }
    }
}