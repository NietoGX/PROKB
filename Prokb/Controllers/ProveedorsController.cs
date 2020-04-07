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
    public class ProveedorsController : ControllerBase
    {
        private ProveedoresRepository _repository;

        public ProveedorsController(ProveedoresRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Proveedors
        [HttpGet]
        public ActionResult<IEnumerable<ProveedorDTO>> GetProveedores()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Proveedors/5
        //[HttpGet("{id}")]
        //public ActionResult<Proveedor> GetProveedor(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Proveedors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProveedor(int id, Proveedor proveedor)
        //{
        //    if (id != proveedor.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(proveedor).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProveedorExists(id))
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

        // POST: api/Proveedors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<ProveedorDTO> PostProveedor(ProveedorDTO proveedor)
        {
            return Ok(_repository.Create(proveedor));
        }

        // DELETE: api/Proveedors/5
        [HttpDelete("{id}")]
        public ActionResult<Proveedor> DeleteProveedor(int id)
        {
            return Ok(_repository.Delete(id));
        }

        
    }
}
