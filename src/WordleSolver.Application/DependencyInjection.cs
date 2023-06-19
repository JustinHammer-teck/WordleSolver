using System.Reflection;
using FluentValidation;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using WordleSolver.Application.Solver;
using WordleSolver.Application.Solver.BehaviorPipeline;
using WordleSolver.Application.Solver.Validation;

namespace WordleSolver.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
 
        services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(PipelineValidationBehavior<,>));

        return services;
    }
}