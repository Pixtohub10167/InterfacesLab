using System.Globalization;

namespace InterfacesLab.Task1;

public class Point : IMovable
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point(int x = 0, int y = 0)
    {
        X = x;
        Y = y;
    }

    /// <summary>Сдвигает точку на указанное смещение.</summary>
    public void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"  Точка смещена на ({x}; {y}) -> новые координаты {this}");
    }

    public override string ToString() =>
        string.Format(CultureInfo.InvariantCulture, "({0}; {1})", X, Y);
}
