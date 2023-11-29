using ApiExample.Classes;
using ApiExample.Interfaces;
using ApiExample.Models;
using ApiExample.Repositories;
using Microsoft.AspNetCore.Mvc;



namespace ApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private CharactersRepository _charactersRepository = new CharactersRepository();
        public CharactersController() { }

        [HttpGet]
        public List<CharacterBase> Index()
        {
            return _charactersRepository.GetAllCharacters();
        }
    }
}
