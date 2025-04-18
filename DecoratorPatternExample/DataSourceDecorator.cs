namespace DecoratorPatternExample;

public abstract class DataSourceDecorator : IDataSource
{
    protected IDataSource _dataSource;

    protected DataSourceDecorator(IDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public virtual void WriteData(string data)
    {
        _dataSource.WriteData(data);
    }

    public virtual string ReadData()
    {
        return _dataSource.ReadData();
    }
}