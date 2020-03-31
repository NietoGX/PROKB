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
    public class TipoIncidenciaSeccionsController : ControllerBase
    {
        private readonly ProkbContext _context;

        public TipoIncidenciaSeccionsController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/TipoIncidenciaSeccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoIncidenciaSeccion>>> GetTiposIncidenciaSeccion()
        {
            return await _context.TiposIncidenciaSeccion.ToListAsync();
        }

        // GET: api/TipoIncidenciaSeccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoIncidenciaSeccion>> GetTipoIncidenciaSeccion(int id)
        {
            var tipoIncidenciaSeccion = await _context.TiposIncidenciaSeccion.FindAsync(id);

            if (tipoIncidenciaSeccion == null)
            {
                return NotFound();
            }

            return tipoIncidenciaSeccion;
        }

        // PUT: api/TipoIncidenciaSeccions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoIncidenciaSeccion(int id, TipoIncidenciaSeccion tipoIncidenciaSeccion)
        {
            if (id != tipoIncidenciaSeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoIncidenciaSeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoIncidenciaSeccionExists(id))
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

        // POST: api/TipoIncidenciaSeccions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TipoIncidenciaSeccion>> PostTipoIncidenciaSeccion(TipoIncidenciaSeccion tipoIncidenciaSeccion)
        {
            _context.TiposIncidenciaSeccion.Add(tipoIncidenciaSeccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoIncidenciaSeccion", new { id = tipoIncidenciaSeccion.Id }, tipoIncidenciaSeccion);
        }

        // DELETE: api/TipoIncidenciaSeccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoIncidenciaSeccion>> DeleteTipoIncidenciaSeccion(int id)
        {
            var tipoIncidenciaSeccion = await _context.TiposIncidenciaSeccion.FindAsync(id);
            if (tipoIncidenciaSeccion == null)
            {
                return NotFound();
            }

            _context.TiposIncidenciaSeccion.Remove(tipoIncidenciaSeccion);
            await _context.SaveChangesAsync();

            return tipoIncidenciaSeccion;
        }

        private bool TipoIncidenciaSeccionExists(int id)
        {
            return _context.TiposIncidenciaSeccion.Any(e => e.Id == id);
        }
    }
}
