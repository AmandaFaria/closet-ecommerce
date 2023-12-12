using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Closet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RoupasController : ControllerBase
    {

        private readonly AppDbContext context;

        public RoupasController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(context.Roupas!.Include
        (x => x.Categoria)
        .ToList());

        [HttpPost]
        public IActionResult Post([FromBody] RoupaDTO roupaDTO)
        {

            var categoria = context.Categorias!.FirstOrDefault(x => x.Id == roupaDTO.CategoriaID);
            if (categoria == null)
            {
                return NotFound();
            }

            var roupaModel = new RoupaModel()
            {
                NomeRoupa = roupaDTO.NomeRoupa,
                DescricaoRoupa = roupaDTO.DescricaoRoupa,
                FotoRoupa = roupaDTO.FotoRoupa,
                Quantidade = roupaDTO.Quantidade,
                Categoria = categoria
            };

            context.Roupas!.Add(roupaModel);
            context.SaveChanges();
            return Created($"/{roupaModel.Id}", roupaModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var roupaModel = context.Roupas!.Include
            (x => x.Categoria).FirstOrDefault(x => x.Id == id);

            if (roupaModel == null)
            {
                return NotFound();
            }

            return Ok(roupaModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,
            [FromBody] RoupaModel roupaModel)
        {
            var model = context.Roupas!.FirstOrDefault(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            model.Id = roupaModel.Id;

            context.Entry(roupaModel).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = context.Roupas!.FirstOrDefault(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            context.Roupas!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
}