using Microsoft.AspNetCore.Mvc;

namespace WordleCopy.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WordsController : Controller
{
    // GET
    [HttpPost("guess")]
    public Task<IActionResult> Index()
    {
        return Ok();
    }
}