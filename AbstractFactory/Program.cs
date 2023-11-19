using AbstractFactory;
using AbstractFactory.Android;
using AbstractFactory.IOs;
using AbstractFactory.Windows;

public class Program
{
    private static readonly IControlFactory _controlFactory;

    static Program()
    {
        var currentPlatform = GetCurrentPlatform();
        _controlFactory = currentPlatform switch
        {
            Platform.Windows => new WindowsControlFactory(),
            Platform.Android => new AndroidControlFactory(),
            Platform.IOs => new IOsControlFactory(),
            _ => throw new NotImplementedException($"Not implemented for {currentPlatform:G}")
        };
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var button = _controlFactory.CreateButton();
        var checkbox = _controlFactory.CreateCheckBox();

        button.OnClick();
        checkbox.Check();
    }

    private static Platform GetCurrentPlatform()
    {
        var number = new Random(DateTime.UtcNow.Microsecond).Next(0, 100);

        return number switch
        {
            var l when l < 33 => Platform.Windows,
            var m when m >= 33 && m < 66 => Platform.Android,
            var h when h >= 66 => Platform.IOs,
            _ => throw new ArgumentException("Not implemented for this environment")
        };
    }

    public enum Platform
    {
        Windows,
        Android,
        IOs,
    }
}