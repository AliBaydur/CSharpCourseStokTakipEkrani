using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
       public int id;
    }

    class Student
    {
        public void Save()
        {
           
        }
    }

    public class Course
    {
        public String Name { get; set; }

        private class NestedClass
        {

        }
    }
}
