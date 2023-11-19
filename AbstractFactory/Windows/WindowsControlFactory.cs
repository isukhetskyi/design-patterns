namespace AbstractFactory.Windows;

public class WindowsControlFactory : IControlFactory
{
    public IButton CreateButton() =>
        new WinButton();

    public ICheckBox CreateCheckBox() =>
        new WinCheckBox();

    public ITextArea CreateTextArea() =>
        new WinTextArea();
}
