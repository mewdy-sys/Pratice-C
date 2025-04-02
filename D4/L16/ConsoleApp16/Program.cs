using System;

public class MyDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public MyDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public static int operator -(MyDate d1, MyDate d2)
    {
        DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
        DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
        return (int)(date1 - date2).TotalDays;
    }

    public static MyDate operator +(MyDate date, int days)
    {
        DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
        dateTime = dateTime.AddDays(days);
        return new MyDate(dateTime.Day, dateTime.Month, dateTime.Year);
    }

    public override string ToString()
    {
        return $"{Day:00}/{Month:00}/{Year}";
    }
}

class Program
{
    static void Main()
    {
        MyDate date1 = new MyDate(1, 1, 2023);
        MyDate date2 = new MyDate(15, 1, 2023);

        int difference = date1 - date2;
        Console.WriteLine($"Разница между датами: {difference} дней");

        MyDate newDate = date1 + 10;
        Console.WriteLine($"Новая дата после увеличения: {newDate}");
    }
}
