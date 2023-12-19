using ApiExample.Classes;
using ApiExample.Interfaces;
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
        private ICharactersRepository _charactersRepository;

        public HeroesController(ICharactersRepository charactersRepository) {
            _charactersRepository = charactersRepository;
        }

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
