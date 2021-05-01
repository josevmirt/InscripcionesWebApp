using InscripcionesWebApp.DAL;
using InscripcionesWebApp.Modelo;
using InscripcionesWebApp.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InscripcionesWebApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspirantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AspirantesController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        //Peticion get Api/Aspirantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aspirante>>> GetAspiranteItems()
        {
            return await _context.Aspirantes.ToListAsync();
        }

        //peticion get un registro api/apirantes/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Aspirante>> GetAspiranteItem(int id)
        {
            var aspiranteItem = await _context.Aspirantes.FindAsync(id);
            if (aspiranteItem == null)
            {
                return NotFound("ERROR! El Id no existe");
            }
            return aspiranteItem;
        }

        //peticion tipo post: api/apsirantes
        [HttpPost]
        public async Task<ActionResult<Aspirante>> PostAspiranteItem(Aspirante item)
        {

            RPAspirante rpCli = new RPAspirante();

            var cliRet = rpCli.VerificarDatos(item);
            if (cliRet)
            {
                return BadRequest("ERROR! Los datos no son los esperados");
            }

            _context.Aspirantes.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAspiranteItem), new { id = item.Id }, item);
        }

        //peticion tipo put: api/aspirante/2
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspiranteItem(int id, Aspirante item)
        {

            RPAspirante rpCli = new RPAspirante();

            var cliRet = rpCli.VerificarDatos(item);
            if (cliRet)
            {
                return BadRequest("ERROR! Los datos no son los esperados");
            }

            if (id != item.Id)
            {
                return BadRequest("ERROR! El Id no existe");
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        //peticion tipo delete api/aspirante/"
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAspiranteItem(int id)
        {
            var aspirantes = await _context.Aspirantes.FindAsync(id);
            if(aspirantes == null)
            {
                return NotFound("ERROR! El Id no existe");
            }
            _context.Aspirantes.Remove(aspirantes);
            await _context.SaveChangesAsync();
            return NoContent();

        }

        }
}
