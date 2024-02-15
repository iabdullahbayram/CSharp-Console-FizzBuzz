using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            Console.WriteLine("bir deger gir");
            string c = Console.ReadLine();
            deger = Convert.ToInt32((string)c);

            for (int i = 1; i <= deger; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
