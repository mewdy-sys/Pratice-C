using System;

public class CalculatorModel
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;   
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль.");
        return a / b;
    }
}

public class ConsoleCalculatorView
{
    public double FirstNumber { get; private set; }
    public double SecondNumber { get; private set; }
    public string Operation { get; private set; }

    public void GetInput()
    {
        Console.Write("Введите первое число: ");
        FirstNumber = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        Operation = Console.ReadLine();

        Console.Write("Введите второе число: ");
        SecondNumber = double.Parse(Console.ReadLine());
    }

    public void ShowResult(double result)
    {
        Console.WriteLine($"Результат: {result}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Ошибка: {message}");
    }
}

public class CalculatorPresenter
{
    private readonly ConsoleCalculatorView _view;
    private readonly CalculatorModel _model;

    public CalculatorPresenter(ConsoleCalculatorView view)
    {
        _view = view;
        _model = new CalculatorModel();
    }

    public void Calculate()
    {
        try
        {
            double result = 0;
            switch (_view.Operation)
            {
                case "+":
                    result = _model.Add(_view.FirstNumber, _view.SecondNumber);
                    break;
                case "-":
                    result = _model.Subtract(_view.FirstNumber, _view.SecondNumber);
                    break;
                case "*":
                    result = _model.Multiply(_view.FirstNumber, _view.SecondNumber);
                    break;
                case "/":
                    result = _model.Divide(_view.FirstNumber, _view.SecondNumber);
                    break;
                default:
                    throw new InvalidOperationException("Неизвестная операция.");
            }
            _view.ShowResult(result);
        }
        catch (Exception ex)
        {
            _view.ShowError(ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        ConsoleCalculatorView view = new ConsoleCalculatorView();
        CalculatorPresenter presenter = new CalculatorPresenter(view);

        view.GetInput();
        presenter.Calculate();
    }
}
