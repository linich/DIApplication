namespace Domain {
    public class Product {
        public string Name { get;set; }
        public decimal UnitPrice { get;set; }
        public bool IsFeatured { get; set; }
        public Product(string name, decimal unitPrice, bool isFeatured) {
            Name = name;
            UnitPrice = unitPrice;
            IsFeatured = isFeatured;
        }
        public DiscountedProduct ApplyDiscountFor( IUserContext user) {
            bool prefered = user.IsUserInRole(Role.PreferedCustomer);
            decimal discount = prefered ? 0.95m : 1.0m;
            return new DiscountedProduct(Name, UnitPrice * discount);
        }
    }
}