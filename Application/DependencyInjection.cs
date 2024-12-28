using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assemply = typeof(DependencyInjection).Assembly;

        services.AddMediatR(conf =>
                conf.RegisterServicesFromAssembly(assemply));

        services.AddValidatorsFromAssembly(assemply);

        return services;
    }
}
