namespace FactoryMethod;

public abstract class LoggerFactory
{
    protected abstract ILogger CreateLogger();

    public ILogger GetLogger()
    {
        return CreateLogger();
    }
}

public class CloudLoggerFactory : LoggerFactory
{
    protected override ILogger CreateLogger()
    {
        return new CloudLogger();
    }
}

public class LocalLoggerFactory : LoggerFactory
{
    protected override ILogger CreateLogger()
    {
        return new Logger();
    }
}

public class DbLoggerFactory : LoggerFactory
{
    protected override ILogger CreateLogger()
    {
        return new DbLogger();
    }
}
