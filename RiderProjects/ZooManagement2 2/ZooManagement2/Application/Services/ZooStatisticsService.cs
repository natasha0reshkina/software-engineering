using System.Linq;
using ZooManagement2.Application.Interfaces;

namespace ZooManagement2.Application.Services
{
    public class ZooStatisticsService : IZooStatisticsService
    {
        private readonly IAnimalRepository _animals;
        private readonly IEnclosureRepository _enclosures;

        public ZooStatisticsService(
            IAnimalRepository animals,
            IEnclosureRepository enclosures)
        {
            _animals = animals;
            _enclosures = enclosures;
        }

        public ZooStatistics GetStatistics()
        {
            var allAnimals = _animals.ListAll().Count();
            var allEnclosures = _enclosures.ListAll().Count();
            var freeEnclosures = _enclosures.ListAll().Count(e => e.CurrentCount < e.Capacity);

            return new ZooStatistics
            {
                TotalAnimals = allAnimals,
                TotalEnclosures = allEnclosures,
                FreeEnclosures = freeEnclosures
            };
        }
    }
}