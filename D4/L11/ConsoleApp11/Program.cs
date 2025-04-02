using System;
using System.Collections.Generic;

public class CarCollection<T>
{
    private List<(string Name, int Year)> _cars = new List<(string Name, int Year)>();

    public void AddCar(string name, int year)
    {
        _cars.Add((name, year));
    }

    public (string Name, int Year) this[int index]
    {
        get { return _cars[index]; }
    }

    public int Count
    {
        get { return _cars.Count; }
    }

    public void Clear()
    {
        _cars.Clear();
    }
}

class Program
{
    static void Main()
    {
        CarCollection<string> carPark = new CarCollection<string>();

        carPark.AddCar("Лада Веста", 2018);
        carPark.AddCar("Honda Accord", 2015);
        carPark.AddCar("Mazda RX-7", 1992);
        Console.WriteLine($"Количество машин: {carPark.Count}");

        for (int i = 0; i < carPark.Count; i++)
        {
            var car = carPark[i];
            Console.WriteLine($"Машина {i + 1}: {car.Name}, {car.Year}");
        }

        carPark.Clear();
        Console.WriteLine($"Количество машин: {carPark.Count}");
    }
}
