#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeacherAssisstantBE.Data;
using TeacherAssisstantBE.Models;

namespace TeacherAssisstantBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectedAnswersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SelectedAnswersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SelectedAnswers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SelectedAnswer>>> GetSelectedAnswer()
        {
            return await _context.SelectedAnswer.ToListAsync();
        }

        // GET: api/SelectedAnswers/weeks
        [HttpGet("weeks")]
        public async Task<ActionResult<IEnumerable<SelectedAnswer>>> GetSelectedAnswerWeeks()
        {
            return await _context.SelectedAnswer.OrderBy(s => s.WeekNumber).OrderBy(w=>w.DayName).ToListAsync();
        }

        // GET: api/SelectedAnswers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SelectedAnswer>> GetSelectedAnswer(int id)
        {
            var selectedAnswer = await _context.SelectedAnswer.FindAsync(id);

            if (selectedAnswer == null)
            {
                return NotFound();
            }

            return selectedAnswer;
        }

        // PUT: api/SelectedAnswers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSelectedAnswer(int id, SelectedAnswer selectedAnswer)
        {
            if (id != selectedAnswer.SelectedAnswerId)
            {
                return BadRequest();
            }

            _context.Entry(selectedAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SelectedAnswerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SelectedAnswers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SelectedAnswer>> PostSelectedAnswer(SelectedAnswer selectedAnswer)
        {
            _context.SelectedAnswer.Add(selectedAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSelectedAnswer", new { id = selectedAnswer.SelectedAnswerId }, selectedAnswer);
        }

        // DELETE: api/SelectedAnswers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSelectedAnswer(int id)
        {
            var selectedAnswer = await _context.SelectedAnswer.FindAsync(id);
            if (selectedAnswer == null)
            {
                return NotFound();
            }

            _context.SelectedAnswer.Remove(selectedAnswer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SelectedAnswerExists(int id)
        {
            return _context.SelectedAnswer.Any(e => e.SelectedAnswerId == id);
        }
    }
}
