using FluentValidation;

namespace WordleSolver.Application.Solver.Validation;

public class SolverRequestValidation : AbstractValidator<SolverRequest>
{
    public SolverRequestValidation()
    {
        RuleFor(x => x.CurrentStage.Guesses).Must(BeAValidWord);
    }

    private bool BeAValidWord(string word)
    {
        return true;
    }
}