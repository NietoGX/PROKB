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
    public class SeccionsController : ControllerBase
    {
        private SeccionesRepository _repository;

        public SeccionsController(SeccionesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Seccions
        [HttpGet]
        public ActionResult<IEnumerable<SeccionDTO>> GetSecciones()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Seccions/5
        //[HttpGet("{id}")]
        //public ActionResult<SeccionDTO> GetSeccion(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Seccions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSeccion(int id, Seccion seccion)
        //{
        //    if (id != seccion.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(seccion).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SeccionExists(id))
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

        // POST: api/Seccions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<SeccionDTO> PostSeccion(SeccionDTO seccion)
        {
            return Ok(_repository.Create(seccion));
        }

        // DELETE: api/Seccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Seccion>> DeleteSeccion(int id)
        {
            return Ok(_repository.Delete(id));
        }

        
    }
}
