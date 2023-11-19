namespace AbstractFactory.Android;

public class AndroidControlFactory : IControlFactory
{
    public IButton CreateButton() =>
        new AndroidButton();

    public ICheckBox CreateCheckBox() =>
        new AndroidCheckBox();

    public ITextArea CreateTextArea() =>
        new AndroidTextArea();
}