using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIApplication.Models;
using Domain;
namespace DIApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _productService;

    public HomeController(ILogger<HomeController> logger, IProductService productService)
    {

        _logger = logger;
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
    }

    public IActionResult Index()
    {
        var products = _productService.GetFeaturedProducts().Select((product) =>new ProductViewModel(product: product));
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
