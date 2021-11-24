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
    public class SelfEvalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SelfEvalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SelfEvals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SelfEval>>> GetSelfEvals()
        {
            return await _context.SelfEvals.ToListAsync();
        }

        // GET: api/SelfEvals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SelfEval>> GetSelfEval(string id)
        {
            var selfEval = await _context.SelfEvals.FindAsync(id);

            if (selfEval == null)
            {
                return NotFound();
            }

            return selfEval;
        }

        // PUT: api/SelfEvals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSelfEval(string id, SelfEval selfEval)
        {
            if (id != selfEval.Id)
            {
                return BadRequest();
            }

            _context.Entry(selfEval).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SelfEvalExists(id))
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

        // POST: api/SelfEvals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SelfEval>> PostSelfEval(SelfEval selfEval)
        {
            _context.SelfEvals.Add(selfEval);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SelfEvalExists(selfEval.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSelfEval", new { id = selfEval.Id }, selfEval);
        }

        // DELETE: api/SelfEvals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSelfEval(string id)
        {
            var selfEval = await _context.SelfEvals.FindAsync(id);
            if (selfEval == null)
            {
                return NotFound();
            }

            _context.SelfEvals.Remove(selfEval);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SelfEvalExists(string id)
        {
            return _context.SelfEvals.Any(e => e.Id == id);
        }
    }
}
