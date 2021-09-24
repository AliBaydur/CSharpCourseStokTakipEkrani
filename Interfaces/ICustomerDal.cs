using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql update");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle update");
        }
    }

    class MySQLCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySQL update");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
