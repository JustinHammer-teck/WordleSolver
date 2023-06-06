using Mediator;
using WordleSolver.Application.Solver.Models;

namespace WordleSolver.Application.Solver;

public record SolverRequest : IRequest<WordleStageDto>
{
}