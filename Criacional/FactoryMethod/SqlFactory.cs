namespace FactoryMethod
{
    //Concrete Creator
    public class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectString)
        {
            return new SqlServerDbConnector(connectString);
        }
    }
}
