using System;

class Program
{
    static void Main()
    {
        Func<int>[] delegates = new Func<int>[]
        {
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100)
        };

        Func<Func<int>[], double> calcAvg = delegate (Func<int>[] funcs)
        {
            double sum = 0;
            foreach (var func in funcs)
            {
                sum += func();
            }
            return sum / funcs.Length;
        };

        double avg = calcAvg(delegates);
        Console.WriteLine($"Среднее: {avg}");
    }
}
