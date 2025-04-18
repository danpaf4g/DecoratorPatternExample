using DecoratorPatternExample;

class Program
{
    static void Main(string[] args)
    {
        // Базовый компонент
        IDataSource fileDataSource = new FileDataSource("example.txt");

        // Оборачиваем в декораторы
        IDataSource loggingDecorator = new LoggingDecorator(fileDataSource);
        IDataSource encryptionDecorator = new EncryptionDecorator(loggingDecorator);

        // Запись данных
        encryptionDecorator.WriteData("Hello, World!");

        // Чтение данных
        string data = encryptionDecorator.ReadData();
        Console.WriteLine($"Final Data: {data}");
    }
}