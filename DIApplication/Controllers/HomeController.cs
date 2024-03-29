using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Domain;
using DIApplication.Models;
namespace DIApplication.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
    }

    public IActionResult Index()
    {
        var products = _productService.GetFeaturedProducts().Select((product) => new ProductViewModel(product: product));
        var vm = new FeaturedProductViewModel(products: products);
        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
    
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
