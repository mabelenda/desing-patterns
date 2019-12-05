using AbstractFactory.Interfaces;

namespace AbstractFactory.ProductosConcretos
{
    class MacButton : IButton
    { 
        public string Click()
        {
            return "Soy un Boton de MAC";
        }
    }
}
