using mcosmetics.Models;
using mcosmetics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace mcosmetics.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsoncosFile cosmeticservice;
        public FormHandlerController(JsoncosFile CosmeticsService)
        {
            this.cosmeticservice = CosmeticsService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            cosmetics obj = new cosmetics();
            obj.product_id = id;
            obj.product_name = name;
            obj.product_image = image;
            IEnumerable<cosmetics> ProData = cosmeticservice.getcosmeticsData();
             List<cosmetics>ListOfProducts= ProData.ToList();
            ListOfProducts.Add(obj);
             return JsonSerializer.Serialize<List<cosmetics>>(ListOfProducts);
        }
    }
}
