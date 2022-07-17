using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyApp.Namespace
{
    public class Familiar_AsignadoModel : PageModel
    {
        private readonly ILogger<Familiar_AsignadoModel> _logger;
        public Familiar_AsignadoModel(ILogger<Familiar_AsignadoModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
