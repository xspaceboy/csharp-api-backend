using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using System.IO;
using Newtonsoft.Json;

namespace PokemonAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private static List<Pokemon> Pokemons = new List<Pokemon>();
    
        public PokemonsController() {
            var jsonData = System.IO.File.ReadAllText("pokemon.json");
            Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(jsonData);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> GetPokemons()
        {
            return Ok(Pokemons);
        }

        [HttpGet("{id}")]
        public ActionResult<Pokemon> GetPokemon(int id)
        {
            var pokemon = Pokemons.FirstOrDefault(p => p.Number == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(pokemon);
        }
    }
}
