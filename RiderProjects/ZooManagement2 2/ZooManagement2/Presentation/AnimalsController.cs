using Microsoft.AspNetCore.Mvc;
using ZooManagement2.Application.Interfaces;
using ZooManagement2.Domain.Entities;
using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalRepository _repo;
        private readonly IAnimalTransferService _transfer;

        public AnimalsController(
            IAnimalRepository repo,
            IAnimalTransferService transfer)
        {
            _repo = repo;
            _transfer = transfer;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repo.ListAll());

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var a = _repo.GetById(new AnimalId(id));
                return Ok(a);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create(CreateAnimalDto dto)
        {
            var animal = new Animal(
                AnimalId.NewId(),
                dto.Species,
                dto.Name,
                dto.BirthDate,
                dto.Gender,
                dto.FavoriteFood);
            _repo.Add(animal);
            return CreatedAtAction(nameof(Get), new { id = animal.Id.Value }, animal);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var a = _repo.GetById(new AnimalId(id));
                _repo.Remove(a);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost("{id}/transfer")]
        public IActionResult Transfer(Guid id, [FromQuery] Guid toEnclosureId)
        {
            _transfer.Transfer(
                new AnimalId(id),
                new EnclosureId(toEnclosureId));
            return NoContent();
        }
    }

    public class CreateAnimalDto
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public FoodType FavoriteFood { get; set; }
    }
}
