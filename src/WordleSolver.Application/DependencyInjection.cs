using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WordleSolver.Application.Solver;
using WordleSolver.Application.Solver.Validation;

namespace WordleSolver.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // services.AddScoped<IValidator<SolverRequest>, SolverRequestValidation>();

        return services;
    }
}