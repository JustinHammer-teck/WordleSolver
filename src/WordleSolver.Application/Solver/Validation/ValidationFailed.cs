using FluentValidation.Results;

namespace WordleSolver.Application.Solver.Validation;

public record ValidationFailed(IEnumerable<ValidationFailure> Errors)
{
    public ValidationFailed(ValidationFailure error) :
        this(new[] { error })
    {
    }
}