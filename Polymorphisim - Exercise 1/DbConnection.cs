using System;

namespace Polymorphisim___Exercise_1
{
    internal abstract class DbConnection
    {
        protected string ConnectionString;
        protected TimeSpan Timeout;
        

        internal DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("No connection string was passed");
            }
            this.ConnectionString = connectionString;
        }

        internal abstract void OpenConnection();
        internal abstract void CloseConnection();
    }
}
