using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public interface IActivityRepository
{
    Task<Activity> AddAsync(Activity activity);
}