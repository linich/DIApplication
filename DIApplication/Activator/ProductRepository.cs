using Domain;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetFeaturedProducts()
    {
        return new List<Product> { 
            new ("name",12.3m, false),
            new ("name2",182.3m, false),
            }.AsQueryable();
    }
}
