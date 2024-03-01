using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Number Master insert a number:");
            string num = Console.ReadLine();
            int n = int.Parse(num);

            if (n > 100 || n < 0)
            {
                    Console.WriteLine("Invalid Number!");
            }

            else
            {
                for (int x=1; x<=100; x++)
                {
                    Console.WriteLine("");
                }
                
                while(true)
                {
                    Console.WriteLine("Number Master insert a number:");
                    string input = Console.ReadLine();
                    int inp = int.Parse(input);

                    if (inp > 100 || inp < 0)
                    {
                        Console.WriteLine("Invalid number! Try again!");
                        continue;
                    }
                    else if (inp < n)
                    {
                        Console.WriteLine("The correct number is higher than " + input);
                        continue;

                    }

                    else if (inp > n)
                    {
                        Console.WriteLine("The correct number is lower than " + input);
                        continue;

                    }

                    else 
                    {
                        Console.WriteLine("Player Wins!");
                        break;
                    }
                }
            }
        }
    }
}
