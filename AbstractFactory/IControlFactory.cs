namespace AbstractFactory;

public interface IControlFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
    ITextArea CreateTextArea();
}
