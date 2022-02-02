using Microsoft.AspNetCore.Mvc;
using WordleCopy.Core.Interfaces.Services;

namespace WordleCopy.Core.Services;

public class WordService : IWordService
{
    public async Task<IActionResult> GuessWord(string word)
    {
        return null;
    }
}