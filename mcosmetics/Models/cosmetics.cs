using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mcosmetics.Models
{
    public class cosmetics
    {
        [JsonPropertyName("id")]
        public int product_id { get; set; }
        [JsonPropertyName("name")]
        public string product_name { get; set; }
        [JsonPropertyName("image")]
        public string product_image { get; set; }

        //to store data in file
        public override string ToString()
        {
             return JsonSerializer.Serialize<cosmetics>(this);
        }
    }
}
