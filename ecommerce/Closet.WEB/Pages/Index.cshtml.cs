using Closet.WEB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Closet.WEB.Pages;

public class IndexModel : PageModel
{

    public List<RoupaModelValue> roupas = new();
    public async Task OnGetAsync()
    {
        HttpClient client = new() { BaseAddress = new Uri("http://localhost:5204/api/Roupas") };

        var response = await client.GetAsync("");

        if (response.IsSuccessStatusCode)
        {
            roupas = RoupaModel.FromJson(
                await response.Content.ReadAsStringAsync()
            ).Values.ToList();
        }
    }
}
