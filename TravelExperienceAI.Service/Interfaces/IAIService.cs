namespace TravelExperienceAI.Service.Interfaces;

public interface IAiService
{
    Task<string> GenerateSummaryAsync(string promptData);
}