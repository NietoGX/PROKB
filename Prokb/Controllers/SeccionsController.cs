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
    public class SeccionsController : ControllerBase
    {
        private readonly ProkbContext _context;

        public SeccionsController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/Seccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seccion>>> GetSecciones()
        {
            return await _context.Secciones.ToListAsync();
        }

        // GET: api/Seccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seccion>> GetSeccion(int id)
        {
            var seccion = await _context.Secciones.FindAsync(id);

            if (seccion == null)
            {
                return NotFound();
            }

            return seccion;
        }

        // PUT: api/Seccions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeccion(int id, Seccion seccion)
        {
            if (id != seccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(seccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeccionExists(id))
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

        // POST: api/Seccions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Seccion>> PostSeccion(Seccion seccion)
        {
            _context.Secciones.Add(seccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeccion", new { id = seccion.Id }, seccion);
        }

        // DELETE: api/Seccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Seccion>> DeleteSeccion(int id)
        {
            var seccion = await _context.Secciones.FindAsync(id);
            if (seccion == null)
            {
                return NotFound();
            }

            _context.Secciones.Remove(seccion);
            await _context.SaveChangesAsync();

            return seccion;
        }

        private bool SeccionExists(int id)
        {
            return _context.Secciones.Any(e => e.Id == id);
        }
    }
}
