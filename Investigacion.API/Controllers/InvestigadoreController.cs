using Investigacion.API.Data;
using Investigacion.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigacion.API.Controllers
{
    [ApiController]
    [Route("/api/investigadores")]
    public class InvestigadoreController:ControllerBase
    {
        private readonly DataContext _Context;

        public InvestigadoreController(DataContext context)
        {
            _Context = context;
        }

        //Get con lista
        //Select * From owners

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _Context.Investigadores.ToListAsync());


        }


        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {
            var Investigadore = await _Context.Investigadores.FirstOrDefaultAsync(x => x.Id == id);

            if (Investigadore == null)
            {
                return NotFound();
            }
            return Ok(Investigadore);
        }

        //insrtar un registro
        [HttpPost]
        public async Task<ActionResult> Post(Investigadore Investigacion)
        {

            _Context.Add(Investigacion);
            await _Context.SaveChangesAsync();
            return Ok(Investigacion);
        }
    }
}

