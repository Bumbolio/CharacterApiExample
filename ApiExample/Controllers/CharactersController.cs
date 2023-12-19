using ApiExample.Classes;
using ApiExample.Data;
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
        private ICharactersRepository _charactersRepository;
        public CharactersController(ICharactersRepository charactersRepository) { 
            _charactersRepository = charactersRepository;
        }


        [HttpGet]
        public List<CharacterBase> Index()
        {
            return _charactersRepository.GetAllCharacters();
        }
    }
}
