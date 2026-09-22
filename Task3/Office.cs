using InterfacesLab.Task3.Good;

namespace InterfacesLab.Task3;

public static class Office
{
    /// <summary>
    /// Метод требует только возможности печати. Ему можно передать и Printer, и МФУ —
    /// но нельзя передать Scanner, и это проверит компилятор.
    /// </summary>
    public static void PrintReport(IPrinter printer, string report) => printer.Print(report);
}
