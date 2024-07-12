using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParallelAndNarrowChange.Method;

namespace ParallelAndNarrowChange.Field
{
    public class ClientOfShoppingCart
    {
        private IShoppingCart _shoppingCart;

        public static void Main(String[] args)
        {
            new ClientOfShoppingCart(new ShoppingCart()).Run();
        }

        public ClientOfShoppingCart(IShoppingCart shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }

        public void Run()
        {
            _shoppingCart.Add(1, "Product1", 10);
            _shoppingCart.Add(2, "Product2", 20);
            _shoppingCart.Add(3, "Product3", 110);

            Console.WriteLine("Total for the shopping cart is = " + _shoppingCart.CalculateTotalPrice());
            Console.WriteLine("Number of Items in the shopping cart is = " + _shoppingCart.NumberOfProducts());
            Console.WriteLine("Does cart has discounted product = " + _shoppingCart.HasDiscount());

            Console.Read();
        }
    }
}
