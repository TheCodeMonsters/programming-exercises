using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Models
{
    public class Pokelista
    {
        [JsonProperty("count")]
        public long cantidad { get; set; }
        [JsonProperty("siguiente")]
        public string siguiente { get; set; }
        [JsonProperty("previus")]
        public object anterior { get; set; }
        [JsonProperty("results")]
        public  List<Pokemon>  listaPokemones { get; set; }
    }
}
