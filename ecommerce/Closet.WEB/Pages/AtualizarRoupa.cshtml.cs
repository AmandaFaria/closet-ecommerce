using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Closet.WEB.Pages
{
    public class AtualizarRoupa : PageModel
    {
        private readonly ILogger<AtualizarRoupa> _logger;

        public AtualizarRoupa(ILogger<AtualizarRoupa> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}