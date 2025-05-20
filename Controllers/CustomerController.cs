using DevPrinciples.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevPrinciples.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    // Version that violates the Law of Demeter
    [HttpPost("customer/street-name-v")]
    public ActionResult<string> GetStreetNameViolation([FromBody] Customer customer)
    {
        if (customer?.Address?.Street == null)
            return NotFound("Street not found");

        // Directly navigating through object graph (violation)
        string streetName = customer.Address.Street.Name;
        return Ok(streetName);
    }

    // Version that follows the Law of Demeter
    [HttpPost("customer/street-name")]
    public ActionResult<string> GetStreetName([FromBody] Customer customer)
    {
        var streetName = customer?.GetStreetName();

        if (string.IsNullOrEmpty(streetName))
            return NotFound("Street not found");

        return Ok(streetName);
    }
}