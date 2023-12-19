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
    public class VillainsController : ControllerBase
    {
        private ICharactersRepository _charactersRepository;

        public VillainsController(ICharactersRepository charactersRepository) { 
            _charactersRepository = charactersRepository;
        }

        [HttpGet]
        public List<Villain> Index()
        {
            return _charactersRepository.GetAllVillains();
        }

        [HttpPost]
        public void Post(Villain villain) { 
            _charactersRepository.AddCharacter(villain);
        }

    }
}
