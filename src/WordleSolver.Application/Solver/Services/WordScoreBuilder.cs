using System.Collections;

namespace WordleSolver.Application.Solver.Services;

public class WordScoreBuilder
{
    public Dictionary<char, int[]> LetterFrequency(IEnumerable<string> words)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        var letterFreq = new Dictionary<char, int[]>();

        // Initialize the dictionary.
        foreach (var c in alphabet)
        {
            letterFreq[c] = new int[5];
        }

        // Calculate the frequencies.
        foreach (var word in words)
        {
            for (int i = 0; i < Math.Min(word.Length, 5); i++)
            {
                char c = word[i];
                if (letterFreq.ContainsKey(c))
                {
                    letterFreq[c][i]++;
                }
            }
        }

        return letterFreq;
    }

    private int[] GetMaxFrequency(Dictionary<char, int[]> letterFeq)
    {
        int[] maxFeq = { 0, 0, 0, 0, 0 };
        foreach (var c in letterFeq)
        {
            for (var i = 0; i < 5; i++)
            {
                if (maxFeq[i] < c.Value[i])
                {
                    maxFeq[i] = c.Value[i];
                }
            }
        }

        return maxFeq;
    }
    public Dictionary<string, double> WordScore(IEnumerable<string> possibleWord,
        Dictionary<char, int[]> letterFeq)
    {
        var wordValue = new Dictionary<string, double>();
        var maxFeq = GetMaxFrequency(letterFeq);
        
        foreach (var word in possibleWord)
        {
            var worRef = word.ToLower();
            double score = 1;
            for (var i = 0; i < 5; i++)
            {
                if (letterFeq.TryGetValue(worRef[i], out var freqs))
                {
                    score *= 1 + Math.Pow(freqs[i] - maxFeq[i], 2);
                }
            }
            wordValue.Add(word, score);
        }

        return wordValue;
    }
    
    public string BestWord(string[] possibleWords, Dictionary<char, int[]> letterFeq)
    {
        var scores = WordScore(possibleWords, letterFeq);
        var minScoreWord = scores
            .Aggregate((min, next) 
                => next.Value < min.Value ? next : min);
        return minScoreWord.Key;
    }
}