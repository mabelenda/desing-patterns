namespace AbstractFactory.Interfaces
{
    public interface IFactory
    {
        IButton CreateButton();

        ICheckbox CreateCheckbox();
    }
}
