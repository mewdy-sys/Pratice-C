using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            ValidateFullName(fullName);

            Console.Write("Введите номер рейса (формат aaxxx): ");
            string flightNumber = Console.ReadLine();
            ValidateFlightNumber(flightNumber);

            Console.Write("Введите номер и серию паспорта (формат xx xx xxxxxx): ");
            string passportNumber = Console.ReadLine();
            ValidatePassportNumber(passportNumber);

            Console.WriteLine("Данные введены корректно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void ValidateFullName(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("ФИО не может быть пустым.");
        }
    }

    static void ValidateFlightNumber(string flightNumber)
    {
        if (string.IsNullOrWhiteSpace(flightNumber))
        {
            throw new ArgumentException("Номер рейса не может быть пустым.");
        }

        string pattern = @"^[a-zA-Z]{2}\d{3}$";
        if (!Regex.IsMatch(flightNumber, pattern))
        {
            throw new ArgumentException("Номер рейса должен быть в формате aaxxx, где а – буква, а x – число.");
        }
    }

    static void ValidatePassportNumber(string passportNumber)
    {
        if (string.IsNullOrWhiteSpace(passportNumber))
        {
            throw new ArgumentException("Номер и серия паспорта не могут быть пустыми.");
        }

        string pattern = @"^\d{2} \d{2} \d{6}$";
        if (!Regex.IsMatch(passportNumber, pattern))
        {
            throw new ArgumentException("Номер и серия паспорта должны быть в формате xx xx xxxxxx, где x – число.");
        }
    }
}
