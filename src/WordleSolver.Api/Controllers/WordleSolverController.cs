using LanguageExt.Common;
using Microsoft.AspNetCore.Mvc;
using WordleSolver.Application.Solver;
using WordleSolver.Application.Solver.Models;
using WordleSolver.Application.Solver.Validation;

namespace WordleSolver.Controllers;

public class WordleSolverController : BaseController
{
    [HttpPost]
    public async Task<Result<WordleStageDto>> SolverHandler([FromBody] SolverRequest request)
    {
        var result = await Mediator.Send(request);
        return result;
    }
}