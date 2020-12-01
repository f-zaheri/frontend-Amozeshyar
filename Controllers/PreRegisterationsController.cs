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
    public class PreRegisterationsController : ControllerBase
    {
        private readonly AmozeshyarDB _context;

        public PreRegisterationsController(AmozeshyarDB context)
        {
            _context = context;
        }

        // GET: api/PreRegisterations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreRegisteration>>> GetPreRegisterations()
        {
            return await _context.PreRegisterations.ToListAsync();
        }

        // GET: api/PreRegisterations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreRegisteration>> GetPreRegisteration(int id)
        {
            var preRegisteration = await _context.PreRegisterations.FindAsync(id);

            if (preRegisteration == null)
            {
                return NotFound();
            }

            return preRegisteration;
        }

        // PUT: api/PreRegisterations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreRegisteration(int id, PreRegisteration preRegisteration)
        {
            if (id != preRegisteration.Id)
            {
                return BadRequest();
            }

            _context.Entry(preRegisteration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreRegisterationExists(id))
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

        // POST: api/PreRegisterations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PreRegisteration>> PostPreRegisteration(PreRegisteration preRegisteration)
        {
            _context.PreRegisterations.Add(preRegisteration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPreRegisteration", new { id = preRegisteration.Id }, preRegisteration);
        }

        // DELETE: api/PreRegisterations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreRegisteration(int id)
        {
            var preRegisteration = await _context.PreRegisterations.FindAsync(id);
            if (preRegisteration == null)
            {
                return NotFound();
            }

            _context.PreRegisterations.Remove(preRegisteration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PreRegisterationExists(int id)
        {
            return _context.PreRegisterations.Any(e => e.Id == id);
        }
    }
}
