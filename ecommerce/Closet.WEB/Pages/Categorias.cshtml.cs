using Closet.WEB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Closet.WEB.Pages
{
    public class Categorias : PageModel
    {
        public List<CategoriaModelValue> categorias = new();
        public async Task OnGetAsync()
        {
            HttpClient client = new(){ BaseAddress = new Uri("http://localhost:5204/api/Categoria")};

            var response = await client.GetAsync("");

            if(response.IsSuccessStatusCode)
            {
                categorias = CategoriaModel.FromJson(
                    await response.Content.ReadAsStringAsync()
                ).Values.ToList();
            }
        }
    }
}