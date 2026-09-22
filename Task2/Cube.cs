namespace InterfacesLab.Task2;

/// <summary>
/// Куб реализует I3DShape, а значит обязан реализовать и унаследованные
/// члены IShape: GetArea() — площадь полной поверхности, GetPerimeter() — сумма длин рёбер.
/// </summary>
public class Cube : I3DShape
{
    public double Side { get; }

    public Cube(double side)
    {
        if (side <= 0)
            throw new ArgumentOutOfRangeException(nameof(side), "Ребро должно быть положительным.");
        Side = side;
    }

    public double GetArea() => 6 * Side * Side;

    public double GetPerimeter() => 12 * Side;

    public double GetVolume() => Side * Side * Side;
}
