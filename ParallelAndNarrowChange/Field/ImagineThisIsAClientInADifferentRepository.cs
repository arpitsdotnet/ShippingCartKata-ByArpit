using System;

namespace ParallelAndNarrowChange.Field{
    public class ImagineThisIsAClientInADifferentRepository{
        public string FormattedTotalPrice(int price){
            var shoppingCart = new ShoppingCart();
            shoppingCart.Add(1, "Product1", price);
            return String.Format("Total price is {0} euro", 
                shoppingCart.CalculateTotalPrice());
        }
    }
}