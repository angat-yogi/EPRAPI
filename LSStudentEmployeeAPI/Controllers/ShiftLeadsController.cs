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
    public class ShiftLeadsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShiftLeadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShiftLeads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShiftLead>>> GetShiftLead()
        {
            return await _context.ShiftLead.ToListAsync();
        }

        // GET: api/ShiftLeads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftLead>> GetShiftLead(int id)
        {
            var shiftLead = await _context.ShiftLead.FindAsync(id);

            if (shiftLead == null)
            {
                return NotFound();
            }

            return shiftLead;
        }

        // PUT: api/ShiftLeads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShiftLead(int id, ShiftLead shiftLead)
        {
            if (id != shiftLead.SLID)
            {
                return BadRequest();
            }

            _context.Entry(shiftLead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftLeadExists(id))
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

        // POST: api/ShiftLeads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShiftLead>> PostShiftLead(ShiftLead shiftLead)
        {
            _context.ShiftLead.Add(shiftLead);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShiftLead", new { id = shiftLead.SLID }, shiftLead);
        }

        // DELETE: api/ShiftLeads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShiftLead(int id)
        {
            var shiftLead = await _context.ShiftLead.FindAsync(id);
            if (shiftLead == null)
            {
                return NotFound();
            }

            _context.ShiftLead.Remove(shiftLead);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShiftLeadExists(int id)
        {
            return _context.ShiftLead.Any(e => e.SLID == id);
        }
    }
}
