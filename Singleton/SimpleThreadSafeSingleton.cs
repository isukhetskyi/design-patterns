namespace Singleton;

public sealed class SimpleThreadSafeSingleton
{
    private static SimpleThreadSafeSingleton? _instance = null;
    private static readonly object _lock = new();

    private SimpleThreadSafeSingleton() { }

    public static SimpleThreadSafeSingleton Instance
    {
        get
        {
            lock(_lock) 
            {
                _instance ??= new SimpleThreadSafeSingleton();
                return _instance;
            }            
        }
    }
}
