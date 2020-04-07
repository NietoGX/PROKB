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
    public class ArticulosController : ControllerBase
    {
        private ArticulosRepository _repository;

        public ArticulosController(ArticulosRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Articulos
        [HttpGet]
        public  ActionResult<IEnumerable<ArticuloDTO>> GetArticulos()
        {
            return Ok(_repository.GetAll());
        }

        //// GET: api/Articulos/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Articulo>> GetArticulo(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Articulos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        //{
        //    if (id != articulo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(articulo).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ArticuloExists(id))
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

        // POST: api/Articulos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<ArticuloDTO> PostArticulo(ArticuloDTO articulo)
        {
            return Ok(_repository.Create(articulo));
        }

        // DELETE: api/Articulos/5
        [HttpDelete("{id}")]
        public ActionResult<ArticuloDTO> DeleteArticulo(int id)
        {
            return Ok(_repository.Delete(id));
        }
       

        
    }
}
