using DIApplication.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
public class ControlActivator : IControllerActivator
{
    public ControlActivator(string connectionString) {
        ArgumentNullException.ThrowIfNull(connectionString);;
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; }
    public object Create(ControllerContext context)
    {
        Type type = context.ActionDescriptor.ControllerTypeInfo.AsType();
        if (type == typeof(HomeController)) {
            var productService = new ProductService(new ProductRepository(), new AspNetUserContextAdapter());
            return new HomeController(productService);
        } else {
            throw new Exception("Unknown controller");
        }
    }

    public void Release(ControllerContext context, object controller)
    {
    }
}