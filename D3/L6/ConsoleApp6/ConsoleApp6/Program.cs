using System;

public static class ArrayExtensions
{
    public static void Sort(this int[] array)
    {
        Array.Sort(array);
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        int arraySize = 10;

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(1, 101);
        }

        Console.WriteLine("Исходный массив случайных чисел:");
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }

        array.Sort();

        Console.WriteLine("\nОтсортированный массив по возрастанию:");
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }
    }
}
