using FactoryMethod;

public class Program
{
    private static readonly ILogger _logger;

    static Program()
    {
        var env = GetEnvironment();
        _logger = env switch
        {
            Environment.Local => new LocalLoggerFactory().GetLogger(),
            Environment.Cloud => new CloudLoggerFactory().GetLogger(),
            Environment.DB => new DbLoggerFactory().GetLogger(),
            _ => throw new NotImplementedException(),
        };
    }
    private static void Main(string[] args)
    {
        var todaysLuckyNumber = new Random(DateTime.UtcNow.Microsecond).Next();

        _logger.Log($"Today lucky number is {todaysLuckyNumber}");
    }

    private static Environment GetEnvironment()
    {
        var number = new Random(DateTime.UtcNow.Microsecond).Next(0, 100);

        return number switch
        {
            var l when l < 33 => Environment.Local,
            var m when m >= 33 && m < 66 => Environment.Cloud,
            var h when h >= 66 => Environment.DB,
            _ => throw new ArgumentException("Not implemented for this environment")
        };
    }

    public enum Environment
    {
        Local,
        Cloud,
        DB,
    }
}