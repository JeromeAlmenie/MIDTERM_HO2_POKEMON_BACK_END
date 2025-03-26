using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MIDTERM_HO3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public PokemonController()
        {
            PokemonRepository.Initialize();
        }
        [HttpGet]
        [Route("get-all")]

        public IActionResult Get()
        {
            return Ok(PokemonRepository.GetPokemonList());
        }
        [HttpGet]
        public IActionResult Get(string? name)
        {
            if (name == null)
                return Ok("Not Okay");

            var result = PokemonRepository.GetPokemonList()
                .Where(x => name.ToLower() == x.Name.ToLower())
                .SingleOrDefault();

            if (result != null)
                return Ok(result);

            return NoContent();
        }
        [HttpPost]
        public IActionResult Post(Pokemon pokemon)
        {
            PokemonRepository.AddPokemon(pokemon);
            return Created();

        }
    }
}
