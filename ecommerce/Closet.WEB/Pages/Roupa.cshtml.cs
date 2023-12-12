using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Closet.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Closet.WEB.Pages
{
    public class Roupa : PageModel
    {
        public RoupaModelValue roupa = new();
        public async Task OnGetAsync(int id)
        {
            try
            {
                HttpClient client = new() { BaseAddress = new Uri("http://localhost:5204/api/Roupas/") };

                var response = await client.GetAsync($"{id}");


                if (response.IsSuccessStatusCode)
                {
                    roupa = RoupaModelValue.FromJson(
                        await response.Content.ReadAsStringAsync()
                    );

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}