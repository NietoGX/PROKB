using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;

namespace Prokb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecisionsController : ControllerBase
    {
        private readonly ProkbContext _context;

        public DecisionsController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/Decisions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Decision>>> GetDecisiones()
        {
            return await _context.Decisiones.ToListAsync();
        }

        // GET: api/Decisions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Decision>> GetDecision(int id)
        {
            var decision = await _context.Decisiones.FindAsync(id);

            if (decision == null)
            {
                return NotFound();
            }

            return decision;
        }

        // PUT: api/Decisions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDecision(int id, Decision decision)
        {
            if (id != decision.Id)
            {
                return BadRequest();
            }

            _context.Entry(decision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DecisionExists(id))
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

        // POST: api/Decisions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Decision>> PostDecision(Decision decision)
        {
            _context.Decisiones.Add(decision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDecision", new { id = decision.Id }, decision);
        }

        // DELETE: api/Decisions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Decision>> DeleteDecision(int id)
        {
            var decision = await _context.Decisiones.FindAsync(id);
            if (decision == null)
            {
                return NotFound();
            }

            _context.Decisiones.Remove(decision);
            await _context.SaveChangesAsync();

            return decision;
        }

        private bool DecisionExists(int id)
        {
            return _context.Decisiones.Any(e => e.Id == id);
        }
    }
}
