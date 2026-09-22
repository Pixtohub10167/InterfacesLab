namespace InterfacesLab.Task3.Bad;

public class OldPrinter : IDevice
{
    public void Print(string document) =>
        Console.WriteLine($"  OldPrinter: печатаю «{document}»");

    // Принтер не умеет сканировать, но обязан реализовать метод
    public void Scan(string document) =>
        throw new NotSupportedException("OldPrinter не поддерживает сканирование.");

    public void Fax(string document) =>
        throw new NotSupportedException("OldPrinter не поддерживает факс.");
}
