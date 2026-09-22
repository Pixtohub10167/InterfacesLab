namespace InterfacesLab.Task4;

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"  [CONSOLE] {message}");
}
