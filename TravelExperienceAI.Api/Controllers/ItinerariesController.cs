using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelExperienceAI.Service.Commands;

namespace TravelExperienceAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItinerariesController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    [Route("generate-summary")]
    public async Task<IActionResult> GenerateSummary([FromBody] GenerateItinerarySummaryCommand command)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var itinerary = await mediator.Send(command);
        return Ok(itinerary);
    }
}