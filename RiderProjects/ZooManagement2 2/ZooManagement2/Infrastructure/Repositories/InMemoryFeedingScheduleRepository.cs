using System;
using System.Collections.Generic;
using System.Linq;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;

namespace ZooManagement2.Infrastructure.Repositories
{
    public class InMemoryFeedingScheduleRepository : IFeedingScheduleRepository
    {
        private readonly List<FeedingSchedule> _store = new();

        public void Add(FeedingSchedule schedule) => _store.Add(schedule);

        public FeedingSchedule GetById(Guid id)
            => _store.SingleOrDefault(x => x.Id == id)
               ?? throw new KeyNotFoundException("Schedule not found");

        public void Update(FeedingSchedule schedule) { }

        public IEnumerable<FeedingSchedule> ListAll() => _store;
    }
}