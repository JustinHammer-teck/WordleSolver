using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WordleSolver.Application.Solver.Validation;
using WordleSolver.Domain.Models;

namespace WordleSolver.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IValidator<WordFrame>, SolverRequestValidation>();
        
        
        return services;
    }
}