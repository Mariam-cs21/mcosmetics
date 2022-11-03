using mcosmetics.Models;
using mcosmetics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcosmetics.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CosmeticController : ControllerBase
    {
        JsoncosFile CosService { get; }
        public CosmeticController(JsoncosFile cosService)
        {
            this.CosService = cosService;
        }
        [HttpGet]
        public IEnumerable<cosmetics> Get()
        {
            return CosService.getcosmeticsData();
        }

    }
}
