using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");
            //Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("Table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adana");

            //Console.WriteLine(cities.Contains("İstanbul"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Ali" });
            customers.Add(new Customer { Id = 2, FirstName = "Seda" });


            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Bilal"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="Eda"},
                new Customer{Id=5, FirstName="Fikriye"}
            });

            Console.WriteLine(customers.Contains(customer1));

            //customers.Clear();

            var Index = customers.IndexOf(customer1);
            Console.WriteLine("Index:{0}", Index);

            var Index1 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index:{0}", Index1);

            customers.Insert(0, customer1);
            customers.Remove(customer1);
            customers.RemoveAll(c => c.FirstName == "Bilal");


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;

            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
