namespace ParallelAndNarrowChange.Field
{
    public interface IShoppingCart
    {
        void Add(int aPrice);
        void AddItem(int productId, string productName, decimal price);
        decimal CalculateTotalItemPrice();
        decimal CalculateTotalPrice();
        bool HasDiscount();
        bool HasItemDiscount();
        int NumberOfProducts();
        int NumberOfItemProducts();
    }
}