using System;
using System.Collections.Generic;
using ZooManagement2.Domain.Entities;

namespace ZooManagement2.Application.Interfaces
{
    public interface IFeedingScheduleRepository
    {
        void Add(FeedingSchedule schedule);
        FeedingSchedule GetById(Guid id);
        void Update(FeedingSchedule schedule);
        IEnumerable<FeedingSchedule> ListAll();
    }
}