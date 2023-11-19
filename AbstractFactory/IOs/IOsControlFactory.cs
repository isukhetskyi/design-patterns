namespace AbstractFactory.IOs;

public class IOsControlFactory : IControlFactory
{
    public IButton CreateButton() =>
        new IOsButton();

    public ICheckBox CreateCheckBox() =>
        new IOsCheckBox();

    public ITextArea CreateTextArea() =>
        new IOsTextArea();
}