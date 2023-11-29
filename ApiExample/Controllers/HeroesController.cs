using ApiExample.Classes;
using ApiExample.Models;
using ApiExample.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private CharactersRepository _charactersRepository = new CharactersRepository();

        public HeroesController() { }

        [HttpGet]
        public List<Hero> Index()
        {
            return _charactersRepository.GetAllCharactersOfType<Hero>();
        }

        [HttpPost]
        public void Post(Hero hero) { 
            _charactersRepository.AddCharacter(hero);
        }

        [HttpDelete]
        public void Delete(Hero hero)
        {
            _charactersRepository.RemoveCharacter(hero);
        }

    }
}
