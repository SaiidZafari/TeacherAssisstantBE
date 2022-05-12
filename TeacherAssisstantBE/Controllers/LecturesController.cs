﻿#nullable disable
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
    public class LecturesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LecturesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Lectures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lecture>>> GetLecture()
        {
            return await _context.Lecture.ToListAsync();
        }

        // GET: api/Lectures/article
        [HttpGet("article")]
        public async Task<ActionResult<IEnumerable<Lecture>>> GetLecturearticle()
        {
            return await _context.Lecture.Include(l => l.Articles).ToListAsync();
        }

        // GET: api/Lectures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lecture>> GetLecture(int id)
        {
            var lecture = await _context.Lecture.FindAsync(id);

            if (lecture == null)
            {
                return NotFound();
            }

            return lecture;
        }

        // PUT: api/Lectures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLecture(int id, Lecture lecture)
        {
            if (id != lecture.LectureId)
            {
                return BadRequest();
            }

            _context.Entry(lecture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LectureExists(id))
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

        // POST: api/Lectures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lecture>> PostLecture(Lecture lecture)
        {
            _context.Lecture.Add(lecture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLecture", new { id = lecture.LectureId }, lecture);
        }

        // DELETE: api/Lectures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLecture(int id)
        {
            var lecture = await _context.Lecture.FindAsync(id);
            if (lecture == null)
            {
                return NotFound();
            }

            _context.Lecture.Remove(lecture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LectureExists(int id)
        {
            return _context.Lecture.Any(e => e.LectureId == id);
        }
    }
}
