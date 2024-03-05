using Domain;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetFeaturedProducts()
    {
        return new List<Product> { 
            new ("name",new (12.3m, new("$")), false),
            new ("name2",new (182.3m, new("$")), false),
            }.AsQueryable();
    }
}
