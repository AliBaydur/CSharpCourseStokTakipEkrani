using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello Word");
            int number1 = 2147483647;
            long number2 = -9223372036854775808;
            short number3 = -32768;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 = 15.3;
            decimal number6 = 10.4m;
            var number7 = 10;
        
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("condition is {0}", condition);
            Console.WriteLine("character is {0}", (int)character);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
