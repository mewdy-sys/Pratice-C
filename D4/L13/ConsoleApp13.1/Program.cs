using System;
using System.Threading;

public class Counter
{
    public static int Value = 0;
    private static readonly object _lock = new object();

    public static void Increment(int amount)
    {
        lock (_lock)
        {
            Value += amount;
            Console.WriteLine($"Счетчик увеличен на {amount}, текущее значение: {Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(() =>
            {
                int increment = random.Next(1, 101);
                Counter.Increment(increment);
            });

            thread.Start();
            thread.Join();
        }
    }
}
