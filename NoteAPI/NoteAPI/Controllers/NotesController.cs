using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteAPI.Data;
using NoteAPI.Dtos;
using NoteAPI.Models;


namespace NoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {

        private readonly AppDbContext _context;

        public NotesController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteDto>>> GetNotes()
        {
            var notes = await _context.Notes
                .Select(n => new NoteDto
                {
                    Id = n.Id,
                    Title = n.Title,
                    Content = n.Content
                })
                .ToListAsync();

            return Ok(notes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteDto>> GetNoteById(int id)
        {
            var note = await _context.Notes
                .Where(n => n.Id == id)
                .Select(n => new NoteDto
                {
                    Id = n.Id,
                    Title = n.Title,
                    Content = n.Content
                })
                .FirstOrDefaultAsync();

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        // POST: api/notes
        [HttpPost]
        public async Task<ActionResult<NoteDto>> CreateNote([FromBody] NoteDto newNoteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var note = new Note
            {
                Title = newNoteDto.Title,
                Content = newNoteDto.Content
            };

            _context.Notes.Add(note);
            await _context.SaveChangesAsync();

            // Return the created note with its new Id
            newNoteDto.Id = note.Id;

            return CreatedAtAction(nameof(GetNoteById), new { id = newNoteDto.Id }, newNoteDto);
        }

        // PUT: api/notes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNote(int id, [FromBody] NoteDto updatedNoteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != updatedNoteDto.Id)
            {
                return BadRequest();
            }

            var note = await _context.Notes.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            note.Title = updatedNoteDto.Title;
            note.Content = updatedNoteDto.Content;

            _context.Entry(note).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Notes.Any(n => n.Id == id))
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: api/notes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
