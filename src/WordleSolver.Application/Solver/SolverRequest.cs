using LanguageExt.Common;
using Mediator;
using WordleSolver.Application.Solver.Models;
using WordleSolver.Domain.Models;

namespace WordleSolver.Application.Solver;

public record SolverRequest(
    WordFrame CurrentStage,
    int Row, 
    IEnumerable<WordFrame> WordleStage) : IRequest<Result<WordleStageDto>> {}
