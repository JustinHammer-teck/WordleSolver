using FluentValidation;
using WordleSolver.Domain.Models;

namespace WordleSolver.Application.Solver.Validation;

public class SolverRequestValidation : AbstractValidator<WordFrame>
{
    public SolverRequestValidation()
    {
        RuleFor(x => x.Guesses).Must(BeAValidWord);
    }

    private bool BeAValidWord(string word)
    {
        
        return true;
    }
}