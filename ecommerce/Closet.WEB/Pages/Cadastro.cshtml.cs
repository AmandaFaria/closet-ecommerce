using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Closet.WEB.Pages.Shared
{
    public class Cadastro : PageModel
    {
        private readonly ILogger<Cadastro> _logger;

        public Cadastro(ILogger<Cadastro> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}