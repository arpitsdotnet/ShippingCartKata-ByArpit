using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<Item> _items = new();

        public decimal CalculateTotalPrice() =>
            _items.Sum(x => x.Price);

        public bool HasDiscount()
        {
            foreach (var item in _items)
            {
                if (item.Price <= 100)
                    continue;

                return item.Price > 100;
            }
            return false;
        }

        public void Add(int productId, string productName, decimal price) =>
            _items.Add(new Item(productId, productName, price));

        public int NumberOfProducts() =>
            _items.Count;

    }
}
