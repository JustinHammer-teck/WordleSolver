using FluentValidation;
using LanguageExt.Common;
using Mediator;
using WordleSolver.Application.Common;
using WordleSolver.Application.Solver.Models;

namespace WordleSolver.Application.Solver;

public class SolverRequestHandler : IRequestHandler<SolverRequest, Result<WordleStageDto>>
{
    private readonly IMediator _mediator;
    private readonly IValidator<SolverRequest> _validator;
    public SolverRequestHandler(
        IMediator mediator, IValidator<SolverRequest> validator)
    {
        _mediator = mediator;
        _validator = validator;
    }
    public async ValueTask<Result<WordleStageDto>> Handle(SolverRequest request, CancellationToken cancellationToken)
    {
        var result = await _validator.ValidateAsync(request, cancellationToken);

        return new Result<WordleStageDto>();
    }
}