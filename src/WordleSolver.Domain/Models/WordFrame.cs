namespace WordleSolver.Domain.Models;

public record WordFrame(
    string Guesses,
    char[] Correctness);
    