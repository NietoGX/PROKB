using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using Prokb.Data.Models;
using Prokb.Repositories;

namespace Prokb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotivoesController : ControllerBase
    {
        private MotivosRepository _repository;

        public MotivoesController(MotivosRepository repository)
        {
            _repository = repository;
        }

        //GET: api/Motivoes
        [HttpGet]
        public ActionResult<IEnumerable<Motivo>> GetMotivos()
        {

            return Ok(_repository.GetAll());
        }

        // GET: api/Motivoes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<MotivoDTO>> GetMotivo(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Motivoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMotivo(int id, Motivo motivo)
        //{
        //    if (id != motivo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(motivo).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MotivoExists(id))
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

        // POST: api/Motivoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<MotivoDTO> PostMotivo(MotivoDTO motivo)
        {
            return Ok(_repository.Create(motivo));
        }

        // DELETE: api/Motivoes/5
        [HttpDelete("{id}")]
        public ActionResult<Motivo> DeleteMotivo(int id)
        {
            return Ok(_repository.Delete(id));
        }

        //private bool MotivoExists(int id)
        //{
        //    return _context.Motivos.Any(e => e.Id == id);
        //}
    }
}
