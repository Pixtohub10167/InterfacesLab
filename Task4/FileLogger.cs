namespace InterfacesLab.Task4;

public class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path) => _path = path;

    public void Log(string message)
    {
        var line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}";
        File.AppendAllText(_path, line + Environment.NewLine);
        Console.WriteLine($"  [FILE]    запись добавлена в {_path}");
    }
}
