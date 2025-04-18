using System.IO;
using DecoratorPatternExample;

public class FileDataSource : IDataSource
{
    private readonly string _fileName;

    public FileDataSource(string fileName)
    {
        _fileName = fileName;
    }

    public void WriteData(string data)
    {
        File.WriteAllText(_fileName, data);
    }

    public string ReadData()
    {
        return File.ReadAllText(_fileName);
    }
}