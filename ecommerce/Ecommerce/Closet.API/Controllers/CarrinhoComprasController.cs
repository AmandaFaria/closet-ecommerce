using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Closet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrinhoComprasController : ControllerBase
    {
        private readonly AppDbContext context;

        public CarrinhoComprasController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(context.CarrinhoCompras!.ToList());
        
        [HttpPost]
        public IActionResult Post([FromBody] CarrinhoCompraModel carrinhoCompraModel)
        {
            context.CarrinhoCompras!.Add(carrinhoCompraModel);
            context.SaveChanges();
            return Created($"/{carrinhoCompraModel.Id}", carrinhoCompraModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var carrinhoCompraModel = context.CarrinhoCompras!.FirstOrDefault(x => x.Id == id);
            if(carrinhoCompraModel == null)
            {
                return NotFound();
            }

            return Ok(carrinhoCompraModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id,
            [FromBody] CarrinhoCompraModel carrinhoCompraModel)
        {
            var model = context.CarrinhoCompras!.FirstOrDefault(x => x.Id == id);
            if(model == null)
            {
                return NotFound();
            }            

            carrinhoCompraModel.Id = id;

            context.Entry(carrinhoCompraModel).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(carrinhoCompraModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = context.CarrinhoCompras!.FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return NotFound();
            }

            context.CarrinhoCompras!.Remove(model);
            context.SaveChanges();
            return Ok(model);
        }
    }
}