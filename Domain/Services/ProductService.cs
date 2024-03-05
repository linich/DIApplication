
namespace Domain {
    public class ProductService: IProductService {
        public ProductService(IProductRepository repository, IUserContext userContext, ICurrencyConverter currencyConverter) {
            Repository = repository ?? throw new NullReferenceException(nameof(repository));
            UserContext = userContext ?? throw new NullReferenceException(nameof(userContext));
            CurrencyConverter = currencyConverter ?? throw new NullReferenceException(nameof(currencyConverter));
        }

        private IProductRepository Repository { get; }
        private IUserContext UserContext { get; }
        private ICurrencyConverter CurrencyConverter { get; }

        public IEnumerable<DiscountedProduct> GetFeaturedProducts()
        {
            var currency = UserContext.Currency;
            return from product in Repository.GetFeaturedProducts() select 
            product.WithUnitPrice(CurrencyConverter.Exchange(product.UnitPrice, currency)).ApplyDiscountFor(UserContext);   
        }
    }
}