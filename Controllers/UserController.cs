using DevPrinciples.Utils;
using Microsoft.AspNetCore.Mvc;

namespace DevPrinciples.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    // Without DRY
    [HttpPost("register")]
    public IActionResult Register([FromBody] string email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            return BadRequest("Invalid email");

        var normalized = email.Trim().ToLower();
        return Ok($"Registered: {normalized}");
    }

    [HttpPost("subscribe")]
    public IActionResult Subscribe([FromBody] string email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            return BadRequest("Invalid email");

        var normalized = email.Trim().ToLower();
        return Ok($"Subscribed: {normalized}");
    }

    // Using DRY
    [HttpPost("register-dry")]
    public IActionResult RegisterDry([FromBody] string email)
    {
        if (!EmailHelper.Normalize(email, out var normalized))
            return BadRequest("Invalid email");

        return Ok($"Registered: {normalized}");
    }

    [HttpPost("subscribe-dry")]
    public IActionResult SubscribeDry([FromBody] string email)
    {
        if (!EmailHelper.Normalize(email, out var normalized))
            return BadRequest("Invalid email");

        return Ok($"Subscribed: {normalized}");
    }
}