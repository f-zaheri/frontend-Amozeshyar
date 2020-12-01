using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Amozeshyar.Database;

namespace Amozeshyar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternsController : ControllerBase
    {
        private readonly AmozeshyarDB _context;

        public InternsController(AmozeshyarDB context)
        {
            _context = context;
        }

        // GET: api/Interns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intern>>> GetInterns()
        {
            return await _context.Interns.ToListAsync();
        }

        // GET: api/Interns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Intern>> GetIntern(int id)
        {
            var intern = await _context.Interns.FindAsync(id);

            if (intern == null)
            {
                return NotFound();
            }

            return intern;
        }

        // PUT: api/Interns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntern(int id, Intern intern)
        {
            if (id != intern.Id)
            {
                return BadRequest();
            }

            _context.Entry(intern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternExists(id))
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

        // POST: api/Interns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Intern>> PostIntern(Intern intern)
        {
            _context.Interns.Add(intern);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntern", new { id = intern.Id }, intern);
        }

        // DELETE: api/Interns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntern(int id)
        {
            var intern = await _context.Interns.FindAsync(id);
            if (intern == null)
            {
                return NotFound();
            }

            _context.Interns.Remove(intern);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InternExists(int id)
        {
            return _context.Interns.Any(e => e.Id == id);
        }
    }
}
