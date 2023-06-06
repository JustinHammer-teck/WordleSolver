using Microsoft.AspNetCore.Mvc;
using WordleSolver.Application.Solver;

namespace WordleSolver.Controllers;

public class WordleSolverController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> SolverHandler()
    {
        var result = await Mediator.Send(new SolverRequest());
        return Ok(result);
    }
}