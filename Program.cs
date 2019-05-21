using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b
            Console.Write("Enter a number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine();


        }
    }
}
