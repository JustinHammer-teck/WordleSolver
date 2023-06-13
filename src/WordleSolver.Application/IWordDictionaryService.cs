namespace WordleSolver.Application;

public interface IWordDictionaryService
{
   IEnumerable<string> GetAllValidWord();
   IEnumerable<string> GetHelperWord();
   IEnumerable<string> GetStateWord();
}