using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Closet.WEB.Pages.Shared
{
    public class DeletarRoupa : PageModel
    {
        private readonly ILogger<DeletarRoupa> _logger;

        public DeletarRoupa(ILogger<DeletarRoupa> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}