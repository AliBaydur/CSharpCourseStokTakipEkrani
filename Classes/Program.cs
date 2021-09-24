using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Adana";
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "Baydur";

            Customer customer1 = new Customer
            {
                Id = 2,
                City = "Adana",
                FirstName = "Seda",
                LastName = "Baydur"
            };
            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }
    }
}
