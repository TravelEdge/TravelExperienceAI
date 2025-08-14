using TravelExperienceAI.Service.Interfaces;

namespace TravelExperienceAI.Service.Services;

public class FakeAiService : IAiService
{
    public Task<string> GenerateSummaryAsync(string promptData)
    {
        return Task.FromResult($"AI-generated summary based on the following: {promptData}");
    }
}