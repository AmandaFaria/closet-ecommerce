using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Closet.WEB.Pages
{
    public class AtualizarCategoria : PageModel
    {
        private readonly ILogger<AtualizarCategoria> _logger;

        public AtualizarCategoria(ILogger<AtualizarCategoria> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}