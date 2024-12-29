using Application.Abstractions.Behaviors;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assemply = typeof(DependencyInjection).Assembly;

        services.AddMediatR(conf =>
        {
            conf.RegisterServicesFromAssembly(assemply);

            conf.AddOpenBehavior(typeof(RequestLoggingPipelineBehavior<,>));
            conf.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
        });

        services.AddValidatorsFromAssembly(assemply, includeInternalTypes: true);

        return services;
    }
}
