using FluentValidation;
using LanguageExt.Common;
using Mediator;
using WordleSolver.Application.Solver.Models;

namespace WordleSolver.Application.Solver;

public class SolverRequestHandler : IRequestHandler<SolverRequest, Result<WordleStageDto>>
{
    private readonly IMediator _mediator;
    public SolverRequestHandler(
        IMediator mediator)
    {
        _mediator = mediator;
    }
    public async ValueTask<Result<WordleStageDto>> Handle(SolverRequest request, CancellationToken cancellationToken)
    {
        
        return new Result<WordleStageDto>();
    }
}