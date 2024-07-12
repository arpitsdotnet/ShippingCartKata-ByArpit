namespace ParallelAndNarrowChange.Field
{
    public class Item(int productId, string productName, decimal price)
    {
        public int Id { get; private set; } = productId;
        public string ProductName { get; private set; } = productName;
        public decimal Price { get; private set; } = price;
    }
}
