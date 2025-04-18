namespace DecoratorPatternExample;

public interface IDataSource
{
    void WriteData(string data);
    string ReadData();
}