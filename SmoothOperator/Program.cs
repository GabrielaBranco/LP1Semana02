using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a non-negative integer:");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            Console.WriteLine(num - 1);
            Console.WriteLine(num);
            Console.WriteLine(num / 2);
            Console.WriteLine(num << 3);
            Console.WriteLine(num ^ 5);

            bool n = num > 10;
            Console.WriteLine(n);
        }
    }
}
