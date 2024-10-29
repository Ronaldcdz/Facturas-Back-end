using System;
using Application.Interfaces;
using Database.Context;
using Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Database;

public static class ServiceRegistration
{
    public static void AddDatabaseLayer(this IServiceCollection services, IConfiguration configuration)
    {

        // Agregando el servicio para inyeccion de depedencia a la hora de usar la base de datos 
            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
               m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));


        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IClienteRepository, ClienteRepository>();
    }
}
