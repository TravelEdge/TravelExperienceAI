using TravelExperienceAI.Service.Data;
using TravelExperienceAI.Service.Entities;

namespace TravelExperienceAI.Service.Repository;

public class ActivityRepository(AppDbContext context) : IActivityRepository
{
    public async Task<Activity> AddAsync(Activity activity)
    {
        context.Activities.Add(activity);
        await context.SaveChangesAsync();
        return activity;
    }
}