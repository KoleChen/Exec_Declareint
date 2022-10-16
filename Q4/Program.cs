using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q4:");
            int number1 = 10;
            int number2 = 99;
            Console.WriteLine("number1是"+number1+" number2是"+number2);
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("兩變數對調的結果為:");
            Console.WriteLine("number1是" + number1 + " number2是" + number2);

        }
    }
}
