using System.ComponentModel.DataAnnotations;
using MediatR;
using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Commands;

public class GenerateItinerarySummaryCommand : IRequest<Itinerary>
{
    [Required]
    public int ItineraryId { get; set; }
}