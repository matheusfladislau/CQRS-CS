using CQRSCS.Application.Interfaces;
using CQRSCS.Application.Mappings;
using CQRSCS.Application.Services;
using CQRSCS.Domain.Interfaces;
using CQRSCS.Infra.Data.Context;
using CQRSCS.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSCS.Infra.IoC;

public static class DependencyInjection {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
        IConfiguration configuration) {

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IOrderProductsRepository, OrderProductsRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IOrderProductService, OrderProductService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IProductService, ProductService>();

        services.AddAutoMapper(typeof(CustomerMapping));
        services.AddAutoMapper(typeof(OrderMapping));
        services.AddAutoMapper(typeof(OrderProductMapping));
        services.AddAutoMapper(typeof(ProductMapping));

        return services;
    }
}
