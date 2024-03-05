namespace DIApplication.Models;

public class FeaturedProductViewModel {
    public FeaturedProductViewModel(IEnumerable<ProductViewModel> products) => Products = products ?? throw new ArgumentNullException(nameof(products));

    public IEnumerable<ProductViewModel> Products { get;}
}