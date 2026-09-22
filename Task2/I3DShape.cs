namespace InterfacesLab.Task2;

/// <summary>Объёмная фигура: наследует контракт плоской и добавляет объём.</summary>
public interface I3DShape : IShape
{
    double GetVolume();
}
