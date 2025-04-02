using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();

        while (true)
        {
            Thread thread = new Thread(() =>
            {
                int number = random.Next(0, 1001);
                ConsoleColor color;

                if (number <= 300)
                {
                    color = ConsoleColor.White;
                }
                else if (number <= 600)
                {
                    color = ConsoleColor.Green;
                }
                else
                {
                    color = ConsoleColor.Red;
                }

                Console.ForegroundColor = color;
                Console.WriteLine(number);
                Console.ResetColor();
            });

            thread.Start();
            thread.Join();
        }
    }
}
