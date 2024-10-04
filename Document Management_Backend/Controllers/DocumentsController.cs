using DocumentManagementBackend.Service;
using DocumentManagementBackend.Model;
using Microsoft.AspNetCore.Mvc;

namespace DocumentManagementBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentsService _documentsService;

        public DocumentsController(IDocumentsService documentsService)
        {
            _documentsService = documentsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Documents>>> GetAllDocuments()
        {
            var documents = await _documentsService.GetAllDocumentsAsync();
            return Ok(documents);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Documents>> GetDocumentsId(int id)
        {
            var documents = await _documentsService.GetDocumentsAsync(id);
            if (documents == null)
                return NotFound();

            return Ok(documents);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateDocuments([FromBody] Documents documents)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _documentsService.CreateDocumentsAsync(documents); 
            return CreatedAtAction(nameof(GetDocumentsId), new { id = documents.Id }, documents);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateDocuments(int id, [FromBody] Documents documents)
        {
            if (id != documents.Id)
                return BadRequest();

            var existingDocuments = await _documentsService.GetDocumentsAsync(id);
            if (existingDocuments == null)
                return NotFound();

            await _documentsService.UpdateDocumentsAsync(documents);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteDocuments(int id)
        {
            var documents = await _documentsService.GetDocumentsAsync(id);
            if (documents == null)
                return NotFound();

            await _documentsService.SoftDeleteDocumentsAsync(id);
            return NoContent();
        }
    }
}
 