using Mediator;

namespace WordleSolver.Application.WordleHelper;

public record WordleHelperRequest(List<string> PossibleWords, int Row) : IRequest<string>
{
}