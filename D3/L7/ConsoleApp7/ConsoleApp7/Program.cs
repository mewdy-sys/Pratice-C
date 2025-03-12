using System;
using System.Linq;

struct Product
{
    public string name;
    public double price;
    public int quantity;
    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {name}, Цена: {price}, Количество: {quantity}");
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[5];
        products[0] = new Product("Молоко", 25, 10);
        products[1] = new Product("Хлеб", 15, 20);
        products[2] = new Product("Масло", 50, 5);
        products[3] = new Product("Сахар", 30, 15);
        products[4] = new Product("Соль", 10, 30);

        var sortedProducts = products.OrderByDescending(p => p.price);

        Console.WriteLine("Продукты, отсортированные по цене (по убыванию): ");
        foreach (var product in sortedProducts)
        {
            product.DisplayInfo();
        }
    }
}
