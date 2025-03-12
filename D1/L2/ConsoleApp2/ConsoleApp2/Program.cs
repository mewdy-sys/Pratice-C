using System;

class Employee
{
    private string firstName;
    private string lastName;
    private string position;
    private double salary;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void PosAndExp(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
    }

    public double CalcSalary()
    {
        if (position == "Главный")
        {
            salary = 1000 + 500 * experience;
        }
        else if (position == "Не главный")
        {
            salary = 500 + 250 * experience;
        }
        return salary;
    }

    public double Nalog()
    {
        return salary * 0.13;
    }

    public void Information()
    {
        Console.WriteLine("О сотруднике:");
        Console.WriteLine($"{lastName}, {firstName}");
        Console.WriteLine($"Зп: {CalcSalary()}");
        Console.WriteLine($"Опыт: {experience}, Должность: {position}");
        Console.WriteLine($"Налог: {Nalog()}");
    }
 }

class Program
{
    static public void Main()
    {
        Employee employee = new Employee("Собянин", "Максим");
        employee.PosAndExp("Главный", 100);

        employee.Information();

        Console.ReadKey();
    }
}