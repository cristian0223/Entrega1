using Investigacion.API.Data;
using Investigacion.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigacion.API.Controllers
{
    [ApiController]
    [Route("/api/proyectoInvestigacions")]
    public class ProyectoInvestigacionsController:ControllerBase
    {

        private readonly   DataContext _Context;

        public ProyectoInvestigacionsController(DataContext context)
        {
            _Context = context;
        }

        //Get con lista
        //Select * From owners

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _Context.ProyectoInvestigacions.ToListAsync());


        }


        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {
            var ProyectoInvestigacion = await _Context.ProyectoInvestigacions.FirstOrDefaultAsync(x => x.Id == id);

            if (ProyectoInvestigacion == null)
            {
                return NotFound();
            }
            return Ok(ProyectoInvestigacion);
        }

        //insrtar un registro
        [HttpPost]
        public async Task<ActionResult> Post(ProyectoInvestigacion proyectoInvestigacion)
        {

            _Context.Add(proyectoInvestigacion);
            await _Context.SaveChangesAsync();
            return Ok(proyectoInvestigacion);
        }
    }
}
