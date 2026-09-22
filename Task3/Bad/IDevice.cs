namespace InterfacesLab.Task3.Bad;

/// <summary>
/// «Толстый» интерфейс — антипример. Нарушает принцип разделения интерфейсов:
/// заставляет каждого реализатора объявлять методы, которые ему не нужны.
/// </summary>
public interface IDevice
{
    void Print(string document);
    void Scan(string document);
    void Fax(string document);
}
