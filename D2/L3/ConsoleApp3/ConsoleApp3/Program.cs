using System;

public class DocumentWorker()
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Про");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Про");
    }
}

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    }
}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ключ доступа:");
        string key = Console.ReadLine();
        DocumentWorker document;
        switch (key)
        {
            case "pro":
                document = new ProDocumentWorker();
                break;
            case "exp":
                document = new ExpertDocumentWorker();
                break;
            default:
                document = new DocumentWorker();
                break;
        }
        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
    }
}