using ApiExample.Classes;
using ApiExample.Interfaces;

namespace ApiExample.Models
{
    public class Hero : CharacterBase, ICharacter
    {
        public override bool IsGood { get; set; } = true;
        public bool IsAntiHero { get { return IsGood && IsEvil; } }
    }
}
