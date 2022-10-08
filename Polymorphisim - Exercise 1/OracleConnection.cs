using System;

namespace Polymorphisim___Exercise_1
{
    internal class OracleConnection : DbConnection
    {
        internal OracleConnection(string connectionString) : base(connectionString) { }
        internal OracleConnection(string server, string database) : base(server + "-" + database) { }
        internal override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection is open");
            this.Timeout = TimeSpan.FromSeconds(10);
        }
        internal override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection is closed");
            this.Timeout = TimeSpan.FromSeconds(10);
        }
    }

}
