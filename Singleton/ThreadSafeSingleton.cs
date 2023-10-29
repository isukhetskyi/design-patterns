namespace Singleton;

public sealed class ThreadSafeSingleton
{
    private static readonly ThreadSafeSingleton _instance = new ThreadSafeSingleton();

    static ThreadSafeSingleton() { }

    public static ThreadSafeSingleton Instance => _instance;
}
