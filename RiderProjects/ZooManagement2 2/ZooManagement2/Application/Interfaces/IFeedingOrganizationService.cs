using System;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Interfaces
{
    public interface IFeedingOrganizationService
    {
        void ScheduleFeeding(Guid scheduleId, AnimalId animalId, DateTime time, FoodType food);
        void CompleteFeeding(Guid scheduleId);
    }
}