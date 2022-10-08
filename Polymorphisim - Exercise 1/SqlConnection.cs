using System;

namespace Polymorphisim___Exercise_1
{
    internal class SqlConnection : DbConnection
    {
        internal SqlConnection(string stringConnection) : base(stringConnection) { }
        internal SqlConnection(string server, string database) : base(server + ";" + database) { }

        internal override void OpenConnection()
        {
            Console.WriteLine("SQL Connection is open");
            this.Timeout = TimeSpan.FromSeconds(5);
        }
        internal override void CloseConnection()
        {
            Console.WriteLine("SQL Connection is closed");
            this.Timeout = TimeSpan.FromSeconds(5);           
        }
    }

    //    public abstract class Father
    //    {
    //        public int GetBigNumber()
    //        {
    //            return 1000;
    //        }
    //        public abstract int GetHugeNumber();

    //        public virtual int GetSmallNumber()
    //        {
    //            return 10;
    //        }
    //    }

    //    public class Son : Father
    //    {
    //        public override int GetHugeNumber()
    //        {
    //            return 1;
    //        }
    //        public override int GetSmallNumber()
    //        {
    //            return 1000;
    //        }

    //    }

    //    public class GrandSon : Son
    //    {
    //           public override int GetSmallNumber()
    //        {
    //            return base.GetSmallNumber();
    //        }
    //    }
}
