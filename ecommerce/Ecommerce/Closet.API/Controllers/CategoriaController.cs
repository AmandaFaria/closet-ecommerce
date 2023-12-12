using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Closet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext context;

        public CategoriaController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(context.Categorias!.ToList());
        
        [HttpPost]
        public IActionResult Post([FromBody] CategoriaDTO categoriaDTO)
        {
            var categoriaModel = new CategoriaModel(id: null, nomeCategoria: categoriaDTO.NomeCategoria);

            context.Categorias!.Add(categoriaModel);
            context.SaveChanges();
            return Created($"/{categoriaDTO.NomeCategoria}", categoriaDTO);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var categoriaModel = context.Categorias!.FirstOrDefault(x => x.Id == id);
            if(categoriaModel == null)
            {
                return NotFound();
            }
            return Ok(categoriaModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id,
            [FromBody] CategoriaModel categoriaModel)
        {
            var model = context.Categorias!.FirstOrDefault(x => x.Id == id);
            if(model == null)
            {
                return NotFound();
            }

            categoriaModel.Id = id;

            context.Entry(categoriaModel).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(categoriaModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = context.Categorias!.FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return NotFound();
            }
    
            context.Categorias!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
}