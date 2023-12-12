using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Closet.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Closet.WEB.Pages
{
    public class DeletarCategoria : PageModel
    {
        [BindProperty]
        public CategoriaModel? Categoria { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpClient client = new()
            {
                BaseAddress = new Uri("http://localhost:5204/api/Categoria")
            };
 
            var response = await client.DeleteAsync($"{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
    }
}