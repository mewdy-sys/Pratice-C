using System;

public enum Workers
{
    Manager = 50,
    Engineer = 60,
    Developer = 70,
    CEO = 80
}

public class Accauntant
{
    public bool AskForBonus(Workers worker, int hours)
    {
        int requredHours = (int)worker;
        return hours > requredHours;
    }
}

class Program
{
    static void Main()
    {
        var employees = new[]
        {
            new { Position = Workers.Manager, Hours = 60, Target = (int)Workers.Manager},
            new { Position = Workers.Engineer, Hours = 40, Target = (int)Workers.Engineer},
            new { Position = Workers.Developer, Hours = 90, Target = (int)Workers.Developer},
            new { Position = Workers.CEO, Hours = 30, Target = (int)Workers.CEO}
        };

        Accauntant accauntant = new Accauntant();

        foreach (var employee in employees)
        {
            string posName = Enum.GetName(typeof(Workers), employee.Position);
            if (accauntant.AskForBonus(employee.Position, employee.Hours))
            {
                Console.WriteLine($"{posName} получает премию, отработав {employee.Hours} из {employee.Target}");
            }
            else
            {
                Console.WriteLine($"{posName} не получает премию, отработав {employee.Hours} из {employee.Target}");
            }

            Console.ReadKey();
        }
    }
}