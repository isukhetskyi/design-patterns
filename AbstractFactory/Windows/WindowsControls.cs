namespace AbstractFactory.Windows;

public class WinButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Windows Button clicked");
    }
}

public class WinCheckBox : ICheckBox
{
    private bool _checked;

    public void Check()
    {
        _checked = !_checked;
        Console.WriteLine($"Windows Checkbox state changed: {_checked}");
    }
}

public class WinTextArea : ITextArea
{
    public string Text { get; set; } = string.Empty;

    public void HandleTextChanged(string text)
    {
        Text = text;
    }
}
