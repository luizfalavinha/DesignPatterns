namespace FactoryMethod
{
    public abstract class DbConnector
    {
        protected DbConnector(string connectString)
        {
            ConnectString = connectString;
        }

        protected string ConnectString { get; set; }
        public abstract Connection Connect();
    }
}
