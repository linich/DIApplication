
namespace Domain {
    public class ProductService: IProductService {
        public ProductService(IProductRepository repository, IUserContext userContext) {
            Repository = repository ?? throw new NullReferenceException(nameof(repository));
            UserContext = userContext ?? throw new NullReferenceException(nameof(userContext));
        }

        private IProductRepository Repository { get; }
        private IUserContext UserContext { get; }

        public IEnumerable<DiscountedProduct> GetFeaturedProducts()
        {
            return from product in Repository.GetFeaturedProducts() select product.ApplyDiscountFor(UserContext);   
        }
    }
}