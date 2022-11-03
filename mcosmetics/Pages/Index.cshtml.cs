using mcosmetics.Models;
using mcosmetics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcosmetics.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<cosmetics> Cosmetics { get; private set; }
        public JsoncosFile cosmeticsService;
        private readonly ILogger<IndexModel> _logger;
        //constructor k through me apni service ko initiate krva liya hai
        public IndexModel(ILogger<IndexModel> logger,
            JsoncosFile cosmeticsservice)

        {
            _logger = logger;
            cosmeticsService = cosmeticsservice;
        }

        public void OnGet()
        {
        }
    }
}
