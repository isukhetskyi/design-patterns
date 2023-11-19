namespace AbstractFactory.Android;

public class AndroidButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Android Button clicked");
    }
}

public class AndroidCheckBox : ICheckBox
{
    private bool _checked;

    public void Check()
    {
        _checked = !_checked;
        Console.WriteLine($"Android Checkbox state changed: {_checked}");
    }
}

public class AndroidTextArea : ITextArea
{
    public string Text { get; set; } = string.Empty;

    public void HandleTextChanged(string text)
    {
        Text = text;
    }
}
