using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public interface IItineraryRepository
{
    Task<Itinerary?> GetByIdWithActivitiesAsync(int id);
    Task UpdateAsync(Itinerary itinerary);
}