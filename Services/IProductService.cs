public class DiscountedProduct {
    public required string Name;
    public  required decimal UnitPrice;
}

public interface IProductService {
    IEnumerable<DiscountedProduct> GetFeaturedProducts();
}