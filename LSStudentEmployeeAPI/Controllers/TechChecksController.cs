using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LSStudentEmployeeAPI.Models;

namespace LSStudentEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechChecksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TechChecksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TechChecks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechCheck>>> GetTechCheck()
        {
            return await _context.TechCheck.ToListAsync();
        }

        // GET: api/TechChecks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TechCheck>> GetTechCheck(int id)
        {
            var techCheck = await _context.TechCheck.FindAsync(id);

            if (techCheck == null)
            {
                return NotFound();
            }

            return techCheck;
        }

        // PUT: api/TechChecks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechCheck(int id, TechCheck techCheck)
        {
            if (id != techCheck.Id)
            {
                return BadRequest();
            }

            _context.Entry(techCheck).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechCheckExists(id))
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

        // POST: api/TechChecks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TechCheck>> PostTechCheck(TechCheck techCheck)
        {
            _context.TechCheck.Add(techCheck);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechCheck", new { id = techCheck.Id }, techCheck);
        }

        // DELETE: api/TechChecks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTechCheck(int id)
        {
            var techCheck = await _context.TechCheck.FindAsync(id);
            if (techCheck == null)
            {
                return NotFound();
            }

            _context.TechCheck.Remove(techCheck);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TechCheckExists(int id)
        {
            return _context.TechCheck.Any(e => e.Id == id);
        }
    }
}
