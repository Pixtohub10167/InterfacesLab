using System.Globalization;

namespace InterfacesLab.Task2;

public static class ShapePrinter
{
    /// <summary>Работает с любой фигурой, знающей только контракт IShape.</summary>
    public static void PrintShapeInfo(IShape shape)
    {
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  {0,-12} площадь = {1,8:F2}   периметр = {2,8:F2}",
            shape.GetType().Name, shape.GetArea(), shape.GetPerimeter()));

        // Проверка расширенного контракта во время выполнения
        if (shape is I3DShape volumetric)
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                "  {0,-12} объём     = {1,8:F2}", "", volumetric.GetVolume()));
    }
}
