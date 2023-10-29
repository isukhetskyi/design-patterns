using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using Singleton;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var summary = BenchmarkRunner.Run<BenchmarkDemo>();
    }
}

public class BenchmarkDemo
{
    private readonly NotThreadSafeSingleton _notThreadSafeSingleton;
    private readonly SimpleThreadSafeSingleton _simpleThreadSafeSingleton;
    private readonly ThreadSafeSingleton _threadSafeSingleton;

    [Benchmark]
    public NotThreadSafeSingleton GetNotThreadSafeSingleton() => NotThreadSafeSingleton.Instance;

    [Benchmark]
    public SimpleThreadSafeSingleton GetSimpleThreadSafeSingleton() => SimpleThreadSafeSingleton.Instance;

    [Benchmark]
    public ThreadSafeSingleton GetThreadSafeSingleton() => ThreadSafeSingleton.Instance;

    [Benchmark]
    public LazySingleton GetLazySingleton() => LazySingleton.Instance;
}