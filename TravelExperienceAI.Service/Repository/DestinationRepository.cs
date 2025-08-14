using TravelExperienceAI.Service.Data;
using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public class DestinationRepository(AppDbContext context) : IDestinationRepository
{
    public async Task<Destination?> GetByIdAsync(int id)
    {
        return await context.Destinations.FindAsync(id);
    }
}