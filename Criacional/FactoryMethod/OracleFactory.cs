namespace FactoryMethod
{
    //Concrete Creator
    public class OracleFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectString)
        {
            return new OracleDbConnector(connectString);
        }
    }
}
