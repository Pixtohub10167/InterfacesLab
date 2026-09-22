namespace InterfacesLab.Task3.Good;

/// <summary>МФУ реализует ровно те контракты, которые действительно поддерживает.</summary>
public class MultifunctionDevice : IPrinter, IScanner, IFax
{
    public void Print(string document) =>
        Console.WriteLine($"  МФУ: печатаю «{document}»");

    public void Scan(string document) =>
        Console.WriteLine($"  МФУ: сканирую «{document}»");

    public void Fax(string document) =>
        Console.WriteLine($"  МФУ: отправляю по факсу «{document}»");
}
