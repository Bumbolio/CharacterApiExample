using ApiExample.Classes;
using ApiExample.Models;

namespace ApiExample.Interfaces
{
    public interface ICharactersRepository
    {
        void AddCharacter(CharacterBase character);
        List<CharacterBase> GetAllCharacters();
        List<T> GetAllCharactersOfType<T>() where T : CharacterBase;
        List<Hero> GetAllHeroes();
        List<Villain> GetAllVillains();
        void RemoveCharacter(CharacterBase character);
    }
}