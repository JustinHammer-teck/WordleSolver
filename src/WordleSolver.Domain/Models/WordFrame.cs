using WordleSolver.Domain.Enums;

namespace WordleSolver.Domain.Models;

public record WordFrame(
    string Guesses,
    IEnumerable<LetterState> Correctness);
    