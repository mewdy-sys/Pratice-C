using System;
using System.Linq;

public class Article
{
    private string productName;
    private string storeName;
    private double price; // цена в гривнах

    public Article(string productName, string storeName, double price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    public string ProductName => productName;

    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {productName}, Магазин: {storeName}, Price: {price} гривен");
    }
}

public class Store
{
    private Article[] articles;

    public Store(Article[] articles)
    {
        this.articles = articles;
    }

    public Article this[string productName] => articles.FirstOrDefault(article => article.ProductName == productName);

    public void DisplayArticle(int i)
    {
        if (i >= 0 && i < articles.Length)
        {
            articles[i].DisplayInfo();
        }
        else
        {
            Console.WriteLine("Такого товара нету");
        }
    }

    public void DisplayArticle(string productName)
    {
        foreach (var article in articles)
        {
            if (article.ProductName == productName)
            {
                article.DisplayInfo();
                return;
            }

        }
        Console.WriteLine("Такого товара нету");
    }


}

class Program
{
    static void Main()
    {
        Article[] articles =
        {
            new Article("Мороженка", "Пятерочка", 20),
            new Article("Чипсы", "Магнит", 50),
            new Article("Кока-Кола", "Верный", 60)
        };

        Store store = new Store(articles);

        Console.Write("Введите индекс товара: ");
        int i = Convert.ToInt32(Console.ReadLine());
        store.DisplayArticle(i);

        Console.Write("Введите имя товара: ");
        string productName = Console.ReadLine();
        Article article = store[productName];
        article.DisplayInfo();
        //store.DisplayArticle(productName);
    }
}