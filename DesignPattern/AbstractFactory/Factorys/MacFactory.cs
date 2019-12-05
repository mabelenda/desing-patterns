using AbstractFactory.Interfaces;
using AbstractFactory.ProductosConcretos;

namespace AbstractFactory.Factorys
{
    public class MacFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
