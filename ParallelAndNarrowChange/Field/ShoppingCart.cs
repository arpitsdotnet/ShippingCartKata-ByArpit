using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<Item> _items = new();

        public decimal CalculateTotalItemPrice() =>
            _items.Sum(x => x.Price);

        public bool HasItemDiscount()
        {
            foreach (var item in _items)
            {
                if (item.Price <= 100)
                    continue;

                return item.Price > 100;
            }
            return false;
        }

        public void AddItem(int productId, string productName, decimal price) =>
            _items.Add(new Item(productId, productName, price));

        public int NumberOfItemProducts() =>
            _items.Count;


        //OLD METHOD
        private decimal price;

        public decimal CalculateTotalPrice()
        {
            return price;
        }

        public bool HasDiscount()
        {
            return price > 100;
        }

        public void Add(int aPrice)
        {
            this.price = aPrice;
        }

        public int NumberOfProducts()
        {
            return 1;
        }
    }
}
