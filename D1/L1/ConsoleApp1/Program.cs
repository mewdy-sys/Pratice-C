using System;

class Rectange
{
    double side1, side2;

    public Rectange(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        return (side1 + side2) * 2;
    }

    public double Area
    {
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первую сторону прямоугольника:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону прямоугольника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectange rectange = new Rectange(side1, side2);

        Console.WriteLine($"Площадь = {rectange.Area}");
        Console.WriteLine($"Площадь = {rectange.Perimeter}");

        Console.ReadKey();
    }
}