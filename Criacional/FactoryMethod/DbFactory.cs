using System;

namespace FactoryMethod
{
    // Abstract Creator
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectString);

        public static DbFactory Database(DataBase database)
        {
            if (database == DataBase.SqlServer)
                return new SqlFactory();

            if (database == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido");
        }
    }
}
