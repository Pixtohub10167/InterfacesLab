using System.Globalization;
using InterfacesLab.Task1;

namespace InterfacesLab.Task2;

/// <summary>Круг реализует сразу два интерфейса: IDrawable и IShape.</summary>
public class Circle : IDrawable, IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть положительным.");
        Radius = radius;
    }

    public void Draw() =>
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Рисую круг радиусом {0:F2}", Radius));

    public double GetArea() => Math.PI * Radius * Radius;

    public double GetPerimeter() => 2 * Math.PI * Radius;
}
