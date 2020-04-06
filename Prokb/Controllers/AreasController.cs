using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using Prokb.Repositories;
using Microsoft.AspNetCore.Authorization;

using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Prokb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : Controller
    {
        private AreasRepository _repository;

        public AreasController(AreasRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Areas
        [HttpGet]
        public ActionResult<List<AreaDTO>> GetAreas()
        {
            return Ok(_repository.GetAll());
        }

        // GET: api/Areas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Area>> GetArea(int id)
        //{

        //}



        // PUT: api/Areas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutArea(int id, Area area)
        //{
        //    if (id != area.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(area).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AreaExists(id))
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

        // POST: api/Areas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<AreaDTO> PostArea(AreaDTO area)
        {
            return Ok(_repository.Create(area));
        }

        // DELETE: api/Areas/5
        //[HttpDelete("{id}")]
        //public  Task<ActionResult<AreaDTO>> DeleteArea(int id)
        //{
        //    return Ok(_repository.Delete(id));
        //}

        //private bool AreaExists(int id)
        //{
        //    return _context.Areas.Any(e => e.Id == id);
        //}
    }
}
