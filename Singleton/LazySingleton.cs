namespace Singleton;

public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> _lazy = new Lazy<LazySingleton>(() => new LazySingleton());

    public static LazySingleton Instance { get {  return _lazy.Value; } }

    private LazySingleton() { }
}
