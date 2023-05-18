using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace WordleSolver.Controllers;

[ApiController]
[Route("[controller]")]
public class WordleSolverController : ControllerBase
{
    [HttpPost]
    public IActionResult SolverHandler()
    {
        return Ok();
    }
}