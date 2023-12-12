using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Closet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioLoginController : ControllerBase
    {
        private readonly AppDbContext context;

        public UsuarioLoginController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(context.UsuarioLogins!.ToList());

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioLoginModel usuarioLoginModel)
        {
            context.UsuarioLogins!.Add(usuarioLoginModel);
            context.SaveChanges();
            return Created($"/{usuarioLoginModel.Id}", usuarioLoginModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuarioLoginModel = context.UsuarioLogins!.FirstOrDefault(x => x.Id == id);
            if(usuarioLoginModel == null)
            {
                return NotFound();
            }

            return Ok(usuarioLoginModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,
            [FromBody] UsuarioLoginModel usuarioLoginModel)
        {
            var model = context.UsuarioLogins!.FirstOrDefault(x => x.Id == id);
            if(model == null)
            {
                return NotFound();
            }

            model.Id = usuarioLoginModel.Id;

            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = context.UsuarioLogins!.FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return NotFound();
            }

            context.UsuarioLogins!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
}