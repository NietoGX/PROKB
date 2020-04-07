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
    public class DocumentosController : ControllerBase
    {
        private  DocumentosRepository _repository;

        public DocumentosController(DocumentosRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Documentos
        [HttpGet]
        public ActionResult<IEnumerable<DocumentoDTO>> GetDocumentos()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Documentos/5
        //[HttpGet("{id}")]
        //public  <ActionResult<Documento>> GetDocumento(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Documentos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDocumento(int id, Documento documento)
        //{
        //    if (id != documento.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(documento).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DocumentoExists(id))
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

        // POST: api/Documentos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public  ActionResult<DocumentoDTO> PostDocumento(DocumentoDTO documento)
        {
            return Ok(_repository.Create(documento));
        }

        // DELETE: api/Documentos/5
        [HttpDelete("{id}")]
        public ActionResult<Documento> DeleteDocumento(int id)
        {
            return Ok(_repository.Delete(id));
        }

        
    }
}
