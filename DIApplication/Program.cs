using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc.Controllers;

internal class Program
{
    private static void Main(string[] args)
    {
        void ConfigureServices([NotNull] IServiceCollection services, [NotNull] IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(services);
            
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddHttpContextAccessor();

            string? connectionString = configuration.GetConnectionString("connectionString");
            if(connectionString != null) {
                services.AddSingleton<IControllerActivator>(new ControlActivator(connectionString));
            } else {
                throw new ArgumentNullException(connectionString);
            }
        }

        var builder = WebApplication.CreateBuilder(args);


        // Add services to the container.
        ConfigureServices(builder.Services, builder.Configuration);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}