using System.Globalization;

namespace InterfacesLab.Task4;

public class Cash : IPayable
{
    public void Pay(decimal amount) =>
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Принято наличными: {0:F2} руб.", amount));
}
