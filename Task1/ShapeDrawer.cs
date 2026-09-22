namespace InterfacesLab.Task1;

public static class ShapeDrawer
{
    /// <summary>
    /// Принимает любой набор отрисовываемых объектов. Конкретные типы неизвестны —
    /// это и есть полиморфизм интерфейсов.
    /// </summary>
    public static void DrawAll(List<IDrawable> shapes)
    {
        foreach (var shape in shapes)
            shape.Draw();
    }
}
