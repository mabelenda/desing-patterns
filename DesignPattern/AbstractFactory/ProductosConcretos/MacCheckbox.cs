using AbstractFactory.Interfaces;

namespace AbstractFactory.ProductosConcretos
{
    class MacCheckbox : ICheckbox
    {
        public string Check()
        {
            return "Soy un Checkbox de Mac";
        }
    }
}
