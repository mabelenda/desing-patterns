using AbstractFactory.Factorys;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    public class Application 
    {
        static void Main(string[] args)
        {
            Build(new MacFactory(), "Sistema Operativo MAC");
            Build(new WinFactory(), "Sitema Operativo Windows");
        }

        public static void Build(IFactory factory, string operativeSystem)
        {
            IButton button = factory.CreateButton();
            ICheckbox checkbox = factory.CreateCheckbox();

            Console.WriteLine("*** " + operativeSystem + " ***");
            Console.WriteLine(button.Click());
            Console.WriteLine(checkbox.Check());
            Console.WriteLine("******************");
        }
    }
}
