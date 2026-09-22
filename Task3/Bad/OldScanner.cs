namespace InterfacesLab.Task3.Bad;

public class OldScanner : IDevice
{
    public void Print(string document) =>
        throw new NotSupportedException("OldScanner не поддерживает печать.");

    public void Scan(string document) =>
        Console.WriteLine($"  OldScanner: сканирую «{document}»");

    public void Fax(string document) =>
        throw new NotSupportedException("OldScanner не поддерживает факс.");
}
