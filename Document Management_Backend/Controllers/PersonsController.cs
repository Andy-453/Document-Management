using Document_Management_Backend.Service;
using DocumentManagementBackend.Model;
using Microsoft.AspNetCore.Mvc;

namespace Document_Management_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsService _personsService;

        public PersonsController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Persons>>> GetAllPersons() 
        {
            var persons = await _personsService.GetAllPersonsAsync();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Persons>> GetPersonsId(int id) 
        {
            var persons = await _personsService.GetPersonsAsync(id);
            if (persons == null)
            return NotFound();

            return Ok(persons);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreatePersons([FromBody] Persons persons) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _personsService.CreatePersonsAsync(persons);
            return CreatedAtAction(nameof(GetPersonsId), new {id = persons.Id}, persons);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePersons(int id, [FromBody] Persons persons) 
        {
            if (id != persons.Id)
                return BadRequest();

            var existingPersons = await _personsService.GetPersonsAsync(id);
            if (existingPersons == null)
                return NotFound();

            await _personsService.UpdatePersonsAsync(persons);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeletePersons(int id) 
        {
            var persons = await _personsService.GetPersonsAsync(id);
            if (persons == null)
                return NotFound();

            await _personsService.SoftDeletePersonsAsync(id);
            return NoContent();
        }
    }
}
