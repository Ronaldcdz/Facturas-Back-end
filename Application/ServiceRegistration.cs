using System;
using Application.Interfaces;
using Application.Interfaces.Services;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceRegistration
{
    public static void AddApplicationLayer(this IServiceCollection services){

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



        services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
        services.AddTransient<IClienteService, ClienteService>();
    }
}
