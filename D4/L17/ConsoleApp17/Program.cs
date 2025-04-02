using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}

public class Buyer
{
    public string Model { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car { Brand = "Лада", Model = "Гранта", Year = 2010, Color = "Black" },
            new Car { Brand = "УАЗ", Model = "Патриот", Year = 2015, Color = "White" },
            new Car { Brand = "Ford", Model = "Focus", Year = 2018, Color = "Blue" }
        };

        List<Buyer> buyers = new List<Buyer>
        {
            new Buyer { Model = "Camry", Name = "Иван Иванов", PhoneNumber = "+7(909)3748323" },
            new Buyer { Model = "Accord", Name = "Петр Петров", PhoneNumber = "+7(982)7438234" }
        };

        var query = from car in cars
                    join buyer in buyers on car.Model equals buyer.Model
                    select new
                    {
                        BuyerName = buyer.Name,
                        BuyerPhone = buyer.PhoneNumber,
                        CarBrand = car.Brand,
                        CarModel = car.Model,
                        CarYear = car.Year,
                        CarColor = car.Color
                    };

        foreach (var item in query)
        {
            Console.WriteLine($"Покупатель: {item.BuyerName}, Телефон: {item.BuyerPhone}");
            Console.WriteLine($"Автомобиль: {item.CarBrand} {item.CarModel}, Год: {item.CarYear}, Цвет: {item.CarColor}");
            Console.WriteLine();
        }
    }
}
