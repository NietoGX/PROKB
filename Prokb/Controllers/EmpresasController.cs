

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prokb.Data.DataDTO;
using Prokb.Repositories;
using System.Collections.Generic;

namespace Prokb.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class EmpresasController : ControllerBase
    {
        
        private EmpresasRepository _repository;

        public EmpresasController(EmpresasRepository repository)
        {
            _repository = repository;
        }


        

        // GET: api/Empresas
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        //public ActionResult<IEnumerable<EmpresaDTO>> GetEmpresas()
        //{
        //    return Ok(_repository.GetAll());
        //}

        //// GET: api/Empresas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Empresa>> GetEmpresa(int id)
        //{
        //    return await Ok(_repository.Get(id)); 
        //}

        // PUT: api/Empresas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEmpresa(int id, Empresa empresa)
        //{
        //    if (id != empresa.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(empresa).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmpresaExists(id))
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

        // POST: api/Empresas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<EmpresaDTO> Create([FromBody]EmpresaDTO dto)
        {

            return Ok(_repository.Create(dto));
        }

        // DELETE: api/Empresas/5
        [HttpDelete("{id}")]
        public ActionResult<EmpresaDTO> DeleteEmpresa(int id)
        {
            return Ok(_repository.Delete(id));
        }

        
    }
}
