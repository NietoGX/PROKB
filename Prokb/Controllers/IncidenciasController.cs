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
    public class IncidenciasController : ControllerBase
    {
        private readonly ProkbContext _context;

        public IncidenciasController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/Incidencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incidencia>>> GetIncidencias()
        {
            return await _context.Incidencias.ToListAsync();
        }

        // GET: api/Incidencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Incidencia>> GetIncidencia(int id)
        {
            var incidencia = await _context.Incidencias.FindAsync(id);

            if (incidencia == null)
            {
                return NotFound();
            }

            return incidencia;
        }

        // PUT: api/Incidencias/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncidencia(int id, Incidencia incidencia)
        {
            if (id != incidencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(incidencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidenciaExists(id))
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

        // POST: api/Incidencias
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Incidencia>> PostIncidencia(Incidencia incidencia)
        {
            _context.Incidencias.Add(incidencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncidencia", new { id = incidencia.Id }, incidencia);
        }

        // DELETE: api/Incidencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Incidencia>> DeleteIncidencia(int id)
        {
            var incidencia = await _context.Incidencias.FindAsync(id);
            if (incidencia == null)
            {
                return NotFound();
            }

            _context.Incidencias.Remove(incidencia);
            await _context.SaveChangesAsync();

            return incidencia;
        }

        private bool IncidenciaExists(int id)
        {
            return _context.Incidencias.Any(e => e.Id == id);
        }
    }
}
