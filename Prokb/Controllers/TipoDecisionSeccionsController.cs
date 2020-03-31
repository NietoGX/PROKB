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
    public class TipoDecisionSeccionsController : ControllerBase
    {
        private readonly ProkbContext _context;

        public TipoDecisionSeccionsController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/TipoDecisionSeccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDecisionSeccion>>> GetTiposDecisionSeccion()
        {
            return await _context.TiposDecisionSeccion.ToListAsync();
        }

        // GET: api/TipoDecisionSeccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoDecisionSeccion>> GetTipoDecisionSeccion(int id)
        {
            var tipoDecisionSeccion = await _context.TiposDecisionSeccion.FindAsync(id);

            if (tipoDecisionSeccion == null)
            {
                return NotFound();
            }

            return tipoDecisionSeccion;
        }

        // PUT: api/TipoDecisionSeccions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoDecisionSeccion(int id, TipoDecisionSeccion tipoDecisionSeccion)
        {
            if (id != tipoDecisionSeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoDecisionSeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDecisionSeccionExists(id))
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

        // POST: api/TipoDecisionSeccions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TipoDecisionSeccion>> PostTipoDecisionSeccion(TipoDecisionSeccion tipoDecisionSeccion)
        {
            _context.TiposDecisionSeccion.Add(tipoDecisionSeccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoDecisionSeccion", new { id = tipoDecisionSeccion.Id }, tipoDecisionSeccion);
        }

        // DELETE: api/TipoDecisionSeccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoDecisionSeccion>> DeleteTipoDecisionSeccion(int id)
        {
            var tipoDecisionSeccion = await _context.TiposDecisionSeccion.FindAsync(id);
            if (tipoDecisionSeccion == null)
            {
                return NotFound();
            }

            _context.TiposDecisionSeccion.Remove(tipoDecisionSeccion);
            await _context.SaveChangesAsync();

            return tipoDecisionSeccion;
        }

        private bool TipoDecisionSeccionExists(int id)
        {
            return _context.TiposDecisionSeccion.Any(e => e.Id == id);
        }
    }
}
