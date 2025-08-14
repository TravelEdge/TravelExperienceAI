namespace TravelExperienceAI.Service.Entities;

public class Activity
{
    public int Id { get; set; }
    public string ActivityType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int ItineraryId { get; set; }
    public Itinerary? Itinerary { get; set; }

    public int DestinationId { get; set; }
    public Destination? Destination { get; set; }
}

