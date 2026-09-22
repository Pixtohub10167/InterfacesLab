using System.Globalization;
using InterfacesLab.Task1;

namespace InterfacesLab.Task2;

public class Rectangle : IDrawable, IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentOutOfRangeException("Стороны должны быть положительными.");
        Width = width;
        Height = height;
    }

    public void Draw() =>
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Рисую прямоугольник {0:F2} x {1:F2}", Width, Height));

    public double GetArea() => Width * Height;

    public double GetPerimeter() => 2 * (Width + Height);
}
