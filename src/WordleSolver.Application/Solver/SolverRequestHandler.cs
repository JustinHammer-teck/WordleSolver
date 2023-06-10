using LanguageExt.Common;
using Mediator;
using WordleSolver.Application.Solver.Models;

namespace WordleSolver.Application.Solver;

public class SolverRequestHandler : IRequestHandler<SolverRequest, Result<WordleStageDto>>
{
    public async ValueTask<Result<WordleStageDto>> Handle(SolverRequest request, CancellationToken cancellationToken)
    {
        return new Result<WordleStageDto>();
    }
}