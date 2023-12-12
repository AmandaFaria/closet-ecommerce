using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Closet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroUsuarioController : ControllerBase
    {
        private readonly AppDbContext context;

        public CadastroUsuarioController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get(
            ) => Ok(context.CadastroUsuarios!.ToList());
        
        [HttpPost]
        public IActionResult Post([FromBody] CadastroUsuarioModel cadastroUsuarioModel
            )
        {
            context.CadastroUsuarios!.Add(cadastroUsuarioModel);
            context.SaveChanges();
            return Created($"/{cadastroUsuarioModel.Id}", cadastroUsuarioModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var cadastroUsuarioModel = context.CadastroUsuarios!.FirstOrDefault(x => x.Id == id);
            if(cadastroUsuarioModel == null)
            {
                return NotFound();
            }

            return Ok(cadastroUsuarioModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(
            int id,
            [FromBody] CadastroUsuarioModel cadastroUsuarioModel)
        {
            var model = context.CadastroUsuarios!.FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return NotFound();
            }

            cadastroUsuarioModel.Id = id;

            context.Entry(cadastroUsuarioModel).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(cadastroUsuarioModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = context.CadastroUsuarios!.FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return NotFound();
            }

            context.CadastroUsuarios!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
}