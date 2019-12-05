using Composite.Components;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // SingleGift sin utilizar la clase CompositeGift, actuando de manera independiente
            var phone = new SingleGift("Samsung", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            // SingleGift utilizando la clase CompositeGift
            var toys = new CompositeGift("Jueguetes");
            var barbieToy = new SingleGift("Barbie", 289);
            var peponaToy = new SingleGift("Pepona", 587);

            toys.Add(barbieToy);
            toys.Add(peponaToy);

            var superhero = new CompositeGift("Superheroes");
            var batman = new SingleGift("Batman", 200);

            superhero.Add(batman);

            toys.Add(superhero);

            Console.WriteLine($"El precio total de todos los juguetes es de: ${toys.CalculateTotalPrice()}");
        }
    }
}
