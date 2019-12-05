using AbstractFactory.Interfaces;

namespace AbstractFactory.ProductosConcretos
{
    class WinButton : IButton
    {
        public string Click()
        {
            return "Soy un Boton de Windows";
        }
    }
}
