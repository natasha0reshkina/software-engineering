using Microsoft.AspNetCore.Mvc;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnclosuresController : ControllerBase
    {
        private readonly IEnclosureRepository _repo;

        public EnclosuresController(IEnclosureRepository repo)
            => _repo = repo;

        [HttpGet]
        public IActionResult GetAll() => Ok(_repo.ListAll());

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try { return Ok(_repo.GetById(new EnclosureId(id))); }
            catch { return NotFound(); }
        }

        [HttpPost]
        public IActionResult Create(CreateEnclosureDto dto)
        {
            var enc = new Enclosure(
                EnclosureId.NewId(),
                dto.Type,
                dto.Size,
                dto.Capacity);
            _repo.Add(enc);
            return CreatedAtAction(nameof(Get), new { id = enc.Id.Value }, enc);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var e = _repo.GetById(new EnclosureId(id));
                _repo.Remove(e);
                return NoContent();
            }
            catch { return NotFound(); }
        }
    }

    public class CreateEnclosureDto
    {
        public EnclosureType Type { get; set; }
        public double Size { get; set; }
        public int Capacity { get; set; }
    }
}