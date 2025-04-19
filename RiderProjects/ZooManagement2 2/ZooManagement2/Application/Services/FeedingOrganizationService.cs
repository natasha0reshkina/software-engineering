using System;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.Events;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Services
{
    public class FeedingOrganizationService : IFeedingOrganizationService
    {
        private readonly IFeedingScheduleRepository _schedules;
        private readonly IEventPublisher _publisher;

        public FeedingOrganizationService(
            IFeedingScheduleRepository schedules,
            IEventPublisher publisher)
        {
            _schedules = schedules;
            _publisher = publisher;
        }

        public void ScheduleFeeding(Guid scheduleId, AnimalId animalId, DateTime time, FoodType food)
        {
            var schedule = new FeedingSchedule(scheduleId, animalId, time, food);
            _schedules.Add(schedule);
        }

        public void CompleteFeeding(Guid scheduleId)
        {
            var schedule = _schedules.GetById(scheduleId);
            schedule.MarkDone();
            _schedules.Update(schedule);

            var @event = new FeedingTimeEvent(scheduleId, schedule.AnimalId, DateTime.UtcNow);
            _publisher.Publish(@event);
        }
    }
}