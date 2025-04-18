namespace DecoratorPatternExample;

public class LoggingDecorator : DataSourceDecorator
{
    public LoggingDecorator(IDataSource dataSource) : base(dataSource) { }

    public override void WriteData(string data)
    {
        Console.WriteLine($"Logging: Writing data '{data}'");
        base.WriteData(data);
    }

    public override string ReadData()
    {
        var data = base.ReadData();
        Console.WriteLine($"Logging: Reading data '{data}'");
        return data;
    }
}