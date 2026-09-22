namespace InterfacesLab.Task3.Good;

public class Printer : IPrinter
{
    public void Print(string document) =>
        Console.WriteLine($"  Printer: печатаю «{document}»");
}
