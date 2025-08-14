using Microsoft.EntityFrameworkCore;
using TravelExperienceAI.Service.Data;
using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public class ItineraryRepository(AppDbContext context) : IItineraryRepository
{
    public async Task<Itinerary?> GetByIdWithActivitiesAsync(int id)
    {
        return await context.Itineraries
            .Include(i => i.Activities)!
            .ThenInclude(a => a.Destination) // Eager load destinations
            .FirstOrDefaultAsync(i => i.Id == id);
    }

    public async Task UpdateAsync(Itinerary itinerary)
    {
        context.Itineraries.Update(itinerary);
        await context.SaveChangesAsync();
    }
}