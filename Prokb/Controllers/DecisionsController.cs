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
    public class DecisionsController : ControllerBase
    {
        private  DecisionesRepository _repository;

        public DecisionsController(DecisionesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Decisions
        [HttpGet]
        public ActionResult<IEnumerable<DecisionDTO>> GetDecisiones()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Decisions/5
        //[HttpGet("{id}")]
        //public <ActionResult<DecisionDTO> GetDecision(int id)
        //{
        //    return Ok(_repository.Get(id));
        //}

        // PUT: api/Decisions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDecision(int id, Decision decision)
        //{
        //    if (id != decision.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(decision).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DecisionExists(id))
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

        // POST: api/Decisions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Decision> PostDecision(DecisionDTO decision)
        {
            return Ok(_repository.Create(decision));
        }

        // DELETE: api/Decisions/5
        [HttpDelete("{id}")]
        public  ActionResult<Decision> DeleteDecision(int id)
        {
            return Ok(_repository.Delete(id));
        }

        
    }
}
