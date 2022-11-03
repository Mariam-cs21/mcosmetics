using mcosmetics.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace mcosmetics.Services
{
    public class JsoncosFile
    {
        public JsoncosFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath {  get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,"data","cosmetics.json");
            }
                }
        public IEnumerable<cosmetics> getcosmeticsData()
        {
            using(var json_file=File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<cosmetics[]>(json_file.ReadToEnd());
            }
        }
    }
}
