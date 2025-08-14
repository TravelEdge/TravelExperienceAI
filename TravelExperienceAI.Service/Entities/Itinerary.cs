namespace TravelExperienceAI.Service.Entities;

public class Itinerary
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Summary { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<Activity>? Activities { get; set; }
}