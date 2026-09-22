namespace InterfacesLab.Task4;

public static class PaymentProcessor
{
    /// <summary>
    /// Принимает любой способ оплаты. Чтобы добавить оплату через СБП,
    /// достаточно написать новый класс — этот метод менять не нужно (принцип OCP).
    /// </summary>
    public static void ProcessPayment(IPayable method, decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной.");

        method.Pay(amount);
    }
}
