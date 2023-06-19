using FluentValidation;
using Mediator;
using ValidationException = FluentValidation.ValidationException;

namespace WordleSolver.Application.Solver.BehaviorPipeline;

public class PipelineValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validator;

    public PipelineValidationBehavior(IEnumerable<IValidator<TRequest>> validator)
    {
        _validator = validator;
    }
    
    public async ValueTask<TResponse> Handle(
        TRequest request, 
        CancellationToken cancellationToken, 
        MessageHandlerDelegate<TRequest, TResponse> next)
    {
        if (!_validator.Any()) return await next(request, cancellationToken);
        
        var context = new ValidationContext<TRequest>(request);

        var validationResult = await Task.WhenAll(
            _validator.Select(v => 
                v.ValidateAsync(context, cancellationToken)));
            
        var failure = validationResult
            .Where(r => r.Errors.Any())
            .SelectMany(r => r.Errors)
            .ToList();

        if (failure.Any())
        {
            throw new ValidationException($"Validation Exception: {failure}");
        }

        return await next(request, cancellationToken);
    }
}