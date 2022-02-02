using Microsoft.AspNetCore.Mvc;

namespace WordleCopy.Core.Interfaces.Services;

public interface IWordService
{
    Task<IActionResult> GuessWord(string word);
}