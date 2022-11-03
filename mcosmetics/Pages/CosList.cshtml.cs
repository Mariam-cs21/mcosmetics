using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcosmetics.Models;
using mcosmetics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mcosmetics.Pages
{
    public class CosListModel : PageModel
    {
        public IEnumerable<cosmetics> Cosmetics;
        JsoncosFile cosmeticsService;
        public CosListModel(JsoncosFile CosmeticsService)
        {
            this.cosmeticsService = CosmeticsService;
        }
        public void OnGet()
        {
            Cosmetics = cosmeticsService.getcosmeticsData();
        }
    }
}
