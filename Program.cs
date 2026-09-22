using System.Globalization;
using System.Text;
using InterfacesLab.Task1;
using InterfacesLab.Task2;
using InterfacesLab.Task3;
using InterfacesLab.Task4;
using BadDevices = InterfacesLab.Task3.Bad;
using GoodDevices = InterfacesLab.Task3.Good;

// Инвариантная культура — чтобы вывод не зависел от региональных настроек ОС
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
Console.OutputEncoding = Encoding.UTF8;

Header("ЗАДАНИЕ 1. Базовые интерфейсы");

Console.WriteLine("1.1. IMovable / Point");
var point = new Point(0, 0);
Console.WriteLine($"  Исходные координаты: {point}");
point.Move(5, 7);
point.Move(-2, 3);

Console.WriteLine();
Console.WriteLine("1.2. IDrawable / список фигур");
var drawables = new List<IDrawable>
{
    new Circle(3),
    new Rectangle(4, 5),
    new Circle(1.5)
};
ShapeDrawer.DrawAll(drawables);

Header("ЗАДАНИЕ 2. Интерфейсы и наследование");

Console.WriteLine("2.1. IShape / PrintShapeInfo");
IShape[] shapes = { new Circle(3), new Rectangle(4, 5) };
foreach (var shape in shapes)
    ShapePrinter.PrintShapeInfo(shape);

Console.WriteLine();
Console.WriteLine("2.2. I3DShape / Cube");
var cube = new Cube(2);
ShapePrinter.PrintShapeInfo(cube);
Console.WriteLine($"  Cube является IShape:   {cube is IShape}");
Console.WriteLine($"  Cube является I3DShape: {cube is I3DShape}");

Header("ЗАДАНИЕ 3. Сегрегация интерфейсов (ISP)");

Console.WriteLine("3.1. «Толстый» интерфейс IDevice — антипример");
var oldPrinter = new BadDevices.OldPrinter();
oldPrinter.Print("Договор.pdf");
try
{
    oldPrinter.Scan("Договор.pdf");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"  ОШИБКА: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("3.2. После разделения интерфейсов");
var printer = new GoodDevices.Printer();
var scanner = new GoodDevices.Scanner();
var mfd = new GoodDevices.MultifunctionDevice();

Office.PrintReport(printer, "Отчёт_за_квартал.docx");
Office.PrintReport(mfd, "Отчёт_за_квартал.docx");
scanner.Scan("Паспорт.jpg");
mfd.Fax("Счёт_№127.pdf");
Console.WriteLine("  Передать Scanner в PrintReport() невозможно — ошибка компиляции.");

Header("ЗАДАНИЕ 4. Интерфейсы и полиморфизм");

Console.WriteLine("4.1. IPayable / ProcessPayment");
var methods = new List<IPayable>
{
    new CreditCard("4276 **** **** 1234"),
    new Cash()
};
PaymentProcessor.ProcessPayment(methods[0], 1500.50m);
PaymentProcessor.ProcessPayment(methods[1], 300m);
try
{
    PaymentProcessor.ProcessPayment(methods[1], -50m);
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("  ОШИБКА: Сумма должна быть положительной.");
}

Console.WriteLine();
Console.WriteLine("4.2. ILogger / DoWork");
Console.WriteLine("  --- вывод через ConsoleLogger ---");
Worker.DoWork(new ConsoleLogger());
Console.WriteLine("  --- вывод через FileLogger ---");
Worker.DoWork(new FileLogger("log.txt"));

Console.WriteLine();
Console.WriteLine("Все задания выполнены.");

static void Header(string title)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 60));
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 60));
}
