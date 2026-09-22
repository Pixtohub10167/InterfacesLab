using System.Globalization;

namespace InterfacesLab.Task4;

public class CreditCard : IPayable
{
    private readonly string _maskedNumber;

    public CreditCard(string maskedNumber) => _maskedNumber = maskedNumber;

    public void Pay(decimal amount) =>
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Списано {0:F2} руб. с карты {1}", amount, _maskedNumber));
}
