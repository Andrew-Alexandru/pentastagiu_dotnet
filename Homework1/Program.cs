using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int r = rng.Next(0, 100);
            while (true)
            {
                Console.WriteLine("Type the number to guess:");
                string st = Console.ReadLine();
                int number = int.Parse(st);
                if (number < r)
                    Console.WriteLine("The number is too small");
                if (number > r)
                    Console.WriteLine("The number is too big");
                if (number == r)
                {
                    Console.WriteLine("The number is {0}", number);
                    break;
                }
            }
        }
    }
}
