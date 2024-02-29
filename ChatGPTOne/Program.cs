using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;
            bool repeat = true;

            while (repeat)
            {
                Console.Write("Place your question? ");
                question = Console.ReadLine();
                
                switch (question)
                {
                    case "Hello, what's your name?":
                        response = "My name is ChatGPTOne!";
                        break;
                    case "How old are you":
                        response = "Im 1 day old!";
                        break;
                    case "What can you do?":
                        response = "Reply to simple questions";
                        break;
                    case "Are you more intelligent than me?":
                        response = "If you play League of Legends, then yes.";
                        break;
                    case "EXIT":
                        response = "Goodbye! :)";
                        repeat = false;
                        break;
                    default:
                        response = "I don't get it";
                        break;
                }

                Console.WriteLine(response);
            }

        }
    }
}
