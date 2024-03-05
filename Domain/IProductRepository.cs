namespace Domain {
    public interface IProductRepository {
        IEnumerable<Product> GetFeaturedProducts();
    }
}