using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Ali", Age = 26 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.AddNew(customer);
            Console.ReadLine();

        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }

}
