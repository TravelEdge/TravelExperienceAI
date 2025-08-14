using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public interface IDestinationRepository
{
    Task<Destination?> GetByIdAsync(int id);
}