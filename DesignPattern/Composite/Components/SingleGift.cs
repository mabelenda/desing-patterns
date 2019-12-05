using System;

namespace Composite.Components
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price) : base(name, price) { }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{name} con el precio: ${price}");

            return price;
        }
    }
}
