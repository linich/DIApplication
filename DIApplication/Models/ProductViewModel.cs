namespace DIApplication.Models;

using System.Globalization;
using Domain;

public class ProductViewModel {
    private static readonly CultureInfo PriceCulture = new CultureInfo("en-US");

    public ProductViewModel(DiscountedProduct product) {
        SummuryText = string.Format(PriceCulture, "{0} {1:C}", product.Name, product.UnitPrice.Amount);
    }

    public string SummuryText { get; }

}
