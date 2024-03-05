namespace Domain
{
    public class DiscountedProduct
    {
        public DiscountedProduct(string name, decimal unitPrice) {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UnitPrice = unitPrice;
        }
        public string Name;
        public decimal UnitPrice;
    }
}