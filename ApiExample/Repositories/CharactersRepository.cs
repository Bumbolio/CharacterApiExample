﻿using ApiExample.Classes;
using ApiExample.Data;
using ApiExample.Interfaces;
using ApiExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace ApiExample.Repositories
{
    public class CharactersRepository : ICharactersRepository
    {
        public CharacterContext ctx;
        public CharactersRepository(CharacterContext _ctx)
        {
            ctx = _ctx;
        }

        public List<CharacterBase> GetAllCharacters()
        {
            return ctx.Characters.ToList();
        }

        public List<T> GetAllCharactersOfType<T>() where T : CharacterBase
        {
            return ctx.Characters.OfType<T>().ToList();
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
            ctx.Characters.Add(character);
            ctx.SaveChanges();
        }

        public void RemoveCharacter(CharacterBase character)
        {
            var characterToDelete = ctx.Characters.Where(c => c.Id == character.Id).FirstOrDefault();

            if (characterToDelete != null)
            {
                ctx.Characters.Remove(characterToDelete);
                ctx.SaveChanges();
                return;
            }

        }

    }
}
