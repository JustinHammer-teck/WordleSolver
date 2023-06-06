using Mediator;
using WordleSolver.Application.Solver.Models;

namespace WordleSolver.Application.Solver;

public class SolverRequestHandler : IRequestHandler<SolverRequest, WordleStageDto>
{
    public ValueTask<WordleStageDto> Handle(SolverRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}