namespace Domain {
    public class Product {
        public string Name { get;set; }
        public Money UnitPrice { get;set; }
        public bool IsFeatured { get; set; }
        public Product(string name, Money unitPrice, bool isFeatured) {
            Name = name;
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
            IsFeatured = isFeatured;
        }
        public Product WithUnitPrice(Money unitPrice) {
            return new (Name, unitPrice, IsFeatured);
        }
        public DiscountedProduct ApplyDiscountFor( IUserContext user) {
            bool prefered = user.IsUserInRole(Role.PreferedCustomer);
            decimal discount = prefered ? 0.95m : 1.0m;
            return new DiscountedProduct(Name, UnitPrice * discount);
        }
    }
}