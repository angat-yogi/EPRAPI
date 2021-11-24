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
    public class FTEReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FTEReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FTEReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FTEReview>>> GetFTEReviews()
        {
            return await _context.FTEReviews.ToListAsync();
        }

        // GET: api/FTEReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FTEReview>> GetFTEReview(string id)
        {
            var fTEReview = await _context.FTEReviews.FindAsync(id);

            if (fTEReview == null)
            {
                return NotFound();
            }

            return fTEReview;
        }

        // PUT: api/FTEReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFTEReview(string id, FTEReview fTEReview)
        {
            if (id != fTEReview.Id)
            {
                return BadRequest();
            }

            _context.Entry(fTEReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FTEReviewExists(id))
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

        // POST: api/FTEReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FTEReview>> PostFTEReview(FTEReview fTEReview)
        {
            _context.FTEReviews.Add(fTEReview);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FTEReviewExists(fTEReview.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFTEReview", new { id = fTEReview.Id }, fTEReview);
        }

        // DELETE: api/FTEReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFTEReview(string id)
        {
            var fTEReview = await _context.FTEReviews.FindAsync(id);
            if (fTEReview == null)
            {
                return NotFound();
            }

            _context.FTEReviews.Remove(fTEReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FTEReviewExists(string id)
        {
            return _context.FTEReviews.Any(e => e.Id == id);
        }
    }
}
