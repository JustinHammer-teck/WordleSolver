using Mediator;

namespace WordleSolver.Application.WordleHelper;

public class WordleHelperHandler : IRequestHandler<WordleHelperRequest, string>
{
    public ValueTask<string> Handle(WordleHelperRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}