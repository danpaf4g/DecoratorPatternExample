namespace DecoratorPatternExample;

public class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(IDataSource dataSource) : base(dataSource) { }

    public override void WriteData(string data)
    {
        var encryptedData = Encrypt(data);
        Console.WriteLine("Encrypting data...");
        base.WriteData(encryptedData);
    }

    public override string ReadData()
    {
        var encryptedData = base.ReadData();
        Console.WriteLine("Decrypting data...");
        return Decrypt(encryptedData);
    }

    private string Encrypt(string data)
    {
        return new string(data.Reverse().ToArray()); // Простое шифрование: реверс строки
    }

    private string Decrypt(string data)
    {
        return new string(data.Reverse().ToArray()); // Расшифровка: реверс строки
    }
}