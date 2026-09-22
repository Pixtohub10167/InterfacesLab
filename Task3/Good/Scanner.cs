namespace InterfacesLab.Task3.Good;

public class Scanner : IScanner
{
    public void Scan(string document) =>
        Console.WriteLine($"  Scanner: сканирую «{document}»");
}
