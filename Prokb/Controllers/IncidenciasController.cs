using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using Prokb.Repositories;

namespace Prokb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenciasController : ControllerBase
    {
        private IncidenciasRepository  _repository;

        public IncidenciasController(IncidenciasRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Incidencias
        [HttpGet]
        public ActionResult<IEnumerable<IncidenciaDTO>> GetIncidencias()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Incidencias/5
        //[HttpGet("{id}")]
        //public ActionResult<IncidenciaDTO> GetIncidencia(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Incidencias/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutIncidencia(int id, Incidencia incidencia)
        //{
        //    if (id != incidencia.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(incidencia).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!IncidenciaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Incidencias
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<IncidenciaDTO> PostIncidencia(IncidenciaDTO incidencia)
        {
            return Ok(_repository.Create(incidencia));
        }

        // DELETE: api/Incidencias/5
        [HttpDelete("{id}")]
        public ActionResult<Incidencia> DeleteIncidencia(int id)
        {
            return Ok(_repository.Delete(id));
        }

        //private bool IncidenciaExists(int id)
        //{
        //    return _context.Incidencias.Any(e => e.Id == id);
        //}
    }
}
