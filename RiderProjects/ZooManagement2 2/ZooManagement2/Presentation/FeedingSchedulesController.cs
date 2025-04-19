using Microsoft.AspNetCore.Mvc;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedingSchedulesController : ControllerBase
    {
        private readonly IFeedingOrganizationService _service;
        private readonly IFeedingScheduleRepository _repo;

        public FeedingSchedulesController(
            IFeedingOrganizationService service,
            IFeedingScheduleRepository repo)
        {
            _service = service;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repo.ListAll());

        [HttpPost]
        public IActionResult Schedule(CreateFeedingDto dto)
        {
            var id = Guid.NewGuid();
            _service.ScheduleFeeding(
                id,
                new AnimalId(dto.AnimalId),
                dto.Time,
                dto.Food);
            return CreatedAtAction(nameof(GetAll), new { id }, null);
        }

        [HttpPost("{id}/complete")]
        public IActionResult Complete(Guid id)
        {
            _service.CompleteFeeding(id);
            return NoContent();
        }
    }

    public class CreateFeedingDto
    {
        public Guid AnimalId { get; set; }
        public DateTime Time { get; set; }
        public FoodType Food { get; set; }
    }
}