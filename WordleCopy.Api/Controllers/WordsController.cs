using Microsoft.AspNetCore.Mvc;

namespace WordleCopy.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WordsController : Controller
{
    // GET
    [HttpPost("guess")]
    public async Task<IActionResult> Index()
    {
        await Task.Delay(100);
        return Ok();
    }
}