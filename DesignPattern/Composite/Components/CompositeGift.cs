using Composite.Interface;
using System;
using System.Collections.Generic;

namespace Composite.Components
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> gifts;

        public CompositeGift(string name) : base(name)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"Los {name} contienen los siguientes precios: ");

            foreach (var gift in gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
