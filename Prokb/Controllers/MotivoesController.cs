using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.Models;

namespace Prokb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotivoesController : ControllerBase
    {
        private readonly ProkbContext _context;

        public MotivoesController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/Motivoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motivo>>> GetMotivos()
        {
            return await _context.Motivos.ToListAsync();
        }

        // GET: api/Motivoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Motivo>> GetMotivo(int id)
        {
            var motivo = await _context.Motivos.FindAsync(id);

            if (motivo == null)
            {
                return NotFound();
            }

            return motivo;
        }

        // PUT: api/Motivoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMotivo(int id, Motivo motivo)
        {
            if (id != motivo.Id)
            {
                return BadRequest();
            }

            _context.Entry(motivo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotivoExists(id))
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

        // POST: api/Motivoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Motivo>> PostMotivo(Motivo motivo)
        {
            _context.Motivos.Add(motivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMotivo", new { id = motivo.Id }, motivo);
        }

        // DELETE: api/Motivoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Motivo>> DeleteMotivo(int id)
        {
            var motivo = await _context.Motivos.FindAsync(id);
            if (motivo == null)
            {
                return NotFound();
            }

            _context.Motivos.Remove(motivo);
            await _context.SaveChangesAsync();

            return motivo;
        }

        private bool MotivoExists(int id)
        {
            return _context.Motivos.Any(e => e.Id == id);
        }
    }
}
