using MediatR;
using TravelExperienceAI.Service.Commands;
using TravelExperienceAI.Service.Entities;
using TravelExperienceAI.Service.Interfaces;
using TravelExperienceAI.Service.Repository;

namespace TravelExperienceAI.Service.Handlers;

public class GenerateItinerarySummaryCommandHandler(IItineraryRepository itineraryRepository, IAiService aiService)
    : IRequestHandler<GenerateItinerarySummaryCommand, Itinerary>
{
    public async Task<Itinerary> Handle(GenerateItinerarySummaryCommand request, CancellationToken cancellationToken)
        {
            // CANDIDATE TASK: Implement this method.

            // 1. Get the Itinerary from the database, including its activities and destinations.
            var itinerary = await itineraryRepository.GetByIdWithActivitiesAsync(request.ItineraryId);
            if (itinerary == null)
            {
                throw new ApplicationException("Itinerary not found.");
            }

            //
            //    The candidate's task is to create a well-structured prompt from this data. You can makle change to use a JSON format for data too if that is better for you.
            //
            var promptData = "Itinerary '" + itinerary.Title + "' includes activities: " +
                             string.Join(", ", itinerary.Activities.Select(a => $"{a.ActivityType} in {a.Destination?.Name}")) +
                             ".";

            // 3. Use the IAIService (Semantic Kernel) to generate a short, creative summary based on the prompt data.
            var generatedSummary = await aiService.GenerateSummaryAsync(promptData);

            // 4. Save the generated summary back to the itinerary entity.
            itinerary.Summary = generatedSummary;
            await itineraryRepository.UpdateAsync(itinerary);

            return itinerary;
        }
    }