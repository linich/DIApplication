namespace Domain
{
    public class DiscountedProduct
    {
        public DiscountedProduct(string name, Money unitPrice) {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        }
        public string Name;
        public Money UnitPrice;
    }
}