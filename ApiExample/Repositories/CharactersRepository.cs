using ApiExample.Classes;
using ApiExample.Interfaces;
using ApiExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace ApiExample.Repositories
{
    public class CharactersRepository
    {
        public static List<CharacterBase> characters = new List<CharacterBase>() {
            new Hero {
                Name = "Iron Man",
                CanFly = true,
                HeightInInches = 73,
                SecretIdentity = "Tony Stark"
            },
            new Villain {
                Name = "Thanos",
                CanFly = true,
                HeightInInches= 79,
                SecretIdentity=""
            }
        };

        public List<CharacterBase> GetAllCharacters() { 
            return characters;
        }

        public List<T> GetAllCharactersOfType<T>() where T : CharacterBase { 
            return characters.OfType<T>().ToList();
        }

        public List<Hero> GetAllHeroes()
        {
            return characters.OfType<Hero>().ToList();
        }

        public List<Villain> GetAllVillains()
        {
            return characters.OfType<Villain>().ToList();
        }

        public void AddCharacter(CharacterBase character)
        {
            characters.Add(character);
        }

        public void RemoveCharacter(CharacterBase character) { 
            var characterToDelete = characters.Where(c => c.Id == character.Id).FirstOrDefault();

            if (characterToDelete != null)
            {
                characters.Remove(characterToDelete);
                return;
            }
            
        }

    }
}
