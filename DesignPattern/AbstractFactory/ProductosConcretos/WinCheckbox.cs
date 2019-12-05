using AbstractFactory.Interfaces;

namespace AbstractFactory.ProductosConcretos
{
    class WinCheckbox : ICheckbox
    {
        public string Check()
        {
            return "Soy un Checkbox de Windows";
        }
    }
}
