using LSStudentEmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagChecksController : Controller
    {
        private ApplicationDbContext _context;
        public BagChecksController(ApplicationDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BagCheck>>> GetBagChecks()
        {
            return await _context.BagChecks.ToListAsync();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<BagCheck>> Get(int id)
        {
            var obj = await _context.BagChecks.FindAsync(id);
            if (obj==null)
            {
                return NotFound();
            }

            return obj;
        }

        //[HttpPost]
        //public async Task<ActionResult<BagCheck>> Post(BagCheck bag)
        //{           
        //    //_context.BagChecks.AddAsync(bag);
        //    await  _context.SaveChangesAsync();
        //    return CreatedAtAction("GetBagChecks", new { id = bag.Id }, bag);
              
        //}





    }
}
