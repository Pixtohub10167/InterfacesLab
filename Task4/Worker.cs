namespace InterfacesLab.Task4;

public static class Worker
{
    /// <summary>
    /// Выполняет работу и сообщает о ходе через переданный логгер.
    /// Класс не знает, куда именно пойдут сообщения.
    /// </summary>
    public static void DoWork(ILogger logger)
    {
        logger.Log("Начало обработки данных");
        logger.Log("Обработано записей: 42");
        logger.Log("Обработка завершена успешно");
    }
}
