using System;
using System.Collections.Generic;

public class Program
{
    public static IEnumerable<int> GetEvenNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IEnumerable<int> evenNumbers = GetEvenNumbers(numbers);

        Console.WriteLine("Четные числа:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
