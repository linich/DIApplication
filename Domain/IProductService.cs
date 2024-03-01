namespace Domain
{
    public interface IProductService {
        IEnumerable<DiscountedProduct> GetFeaturedProducts();
    }
}