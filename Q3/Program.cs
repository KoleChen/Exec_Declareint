using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q3:");
            int number1 = 9;
            int number2 = 202;
            if (number1%2 == 0)
            {
                Console.WriteLine(number1 + "是偶數");
            }
            else
            {
                Console.WriteLine(number1 + "是奇數");
            }
            if (number2 % 2 == 0)
            {
                Console.WriteLine(number2 + "是偶數");
            }
            else
            {
                Console.WriteLine(number2 + "是奇數");
            }
        }
    }
}
