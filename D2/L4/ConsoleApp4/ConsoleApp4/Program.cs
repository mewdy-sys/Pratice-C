using System;

public abstract class Figure
{
    public abstract int GetSquare();
    public abstract int GetPerimeter();
}

public interface IFigure
{
    int GetSquare();
    int GetPerimeter();
}

public class Rectangle : Figure
{
    private int side1;
    private int side2;

    public Rectangle(int side1, int side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override int GetSquare()
    {
        return (int)side1 * side2;
    }

    public override int GetPerimeter()
    {
        return (int)2 * (side1 + side2);
    }
}

public class  Circle : IFigure
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public int GetSquare()
    {
        return (int)(Math.PI * radius * radius);
    }

    public int GetPerimeter()
    {
        return (int)(2 * Math.PI * radius);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую сторону прямоугольника:");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону прямоугольника:");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Площадь: {rectangle.GetSquare()}, Периметр: {rectangle.GetPerimeter()}");

        Console.WriteLine("Введите радиус круга:");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle circle = new Circle(radius);
        Console.WriteLine($"Площадь круга: {circle.GetSquare()}, Длинна окружности: {circle.GetPerimeter()}");
    }
}