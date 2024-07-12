namespace ParallelAndNarrowChange.Field
{
    public interface IShoppingCart
    {
        void Add(int productId, string productName, decimal price);
        decimal CalculateTotalPrice();
        bool HasDiscount();
        int NumberOfProducts();
    }
}