using ApiExample.Classes;
using ApiExample.Data;
using ApiExample.Interfaces;
using ApiExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace ApiExample.Repositories
{
    public class CharactersInMemoryRepository : ICharactersRepository
    {
        private List<CharacterBase> characters { get; set; } = new List<CharacterBase>();
        public CharactersInMemoryRepository()
        {
        }

        public List<CharacterBase> GetAllCharacters()
        {
            return characters;
        }

        public List<T> GetAllCharactersOfType<T>() where T : CharacterBase
        {
            return characters.OfType<T>().ToList();
        }

        public List<Hero> GetAllHeroes()
        {
            return GetAllCharactersOfType<Hero>();
        }

        public List<Villain> GetAllVillains()
        {
            return GetAllCharactersOfType<Villain>();
        }

        public void AddCharacter(CharacterBase character)
        {
            characters.Add(character);
        }

        public void RemoveCharacter(CharacterBase character)
        {
            var characterToDelete = characters.Where(c => c.Id == character.Id).FirstOrDefault();

            if (characterToDelete != null)
            {
                characters.Remove(characterToDelete);
            }

        }

    }
}
