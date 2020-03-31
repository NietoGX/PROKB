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
    public class EmpresaAreaSeccionUsuariosController : ControllerBase
    {
        private readonly ProkbContext _context;

        public EmpresaAreaSeccionUsuariosController(ProkbContext context)
        {
            _context = context;
        }

        // GET: api/EmpresaAreaSeccionUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpresaAreaSeccionUsuario>>> GetEmpresaAreaSeccionUsuarios()
        {
            return await _context.EmpresaAreaSeccionUsuarios.ToListAsync();
        }

        // GET: api/EmpresaAreaSeccionUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaAreaSeccionUsuario>> GetEmpresaAreaSeccionUsuario(int id)
        {
            var empresaAreaSeccionUsuario = await _context.EmpresaAreaSeccionUsuarios.FindAsync(id);

            if (empresaAreaSeccionUsuario == null)
            {
                return NotFound();
            }

            return empresaAreaSeccionUsuario;
        }

        // PUT: api/EmpresaAreaSeccionUsuarios/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresaAreaSeccionUsuario(int id, EmpresaAreaSeccionUsuario empresaAreaSeccionUsuario)
        {
            if (id != empresaAreaSeccionUsuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(empresaAreaSeccionUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaAreaSeccionUsuarioExists(id))
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

        // POST: api/EmpresaAreaSeccionUsuarios
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<EmpresaAreaSeccionUsuario>> PostEmpresaAreaSeccionUsuario(EmpresaAreaSeccionUsuario empresaAreaSeccionUsuario)
        {
            _context.EmpresaAreaSeccionUsuarios.Add(empresaAreaSeccionUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpresaAreaSeccionUsuario", new { id = empresaAreaSeccionUsuario.Id }, empresaAreaSeccionUsuario);
        }

        // DELETE: api/EmpresaAreaSeccionUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpresaAreaSeccionUsuario>> DeleteEmpresaAreaSeccionUsuario(int id)
        {
            var empresaAreaSeccionUsuario = await _context.EmpresaAreaSeccionUsuarios.FindAsync(id);
            if (empresaAreaSeccionUsuario == null)
            {
                return NotFound();
            }

            _context.EmpresaAreaSeccionUsuarios.Remove(empresaAreaSeccionUsuario);
            await _context.SaveChangesAsync();

            return empresaAreaSeccionUsuario;
        }

        private bool EmpresaAreaSeccionUsuarioExists(int id)
        {
            return _context.EmpresaAreaSeccionUsuarios.Any(e => e.Id == id);
        }
    }
}
