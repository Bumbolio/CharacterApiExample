using ApiExample.Classes;
using ApiExample.Interfaces;

namespace ApiExample.Models
{
    public class Villain : CharacterBase, ICharacter
    {
        public override bool IsGood { get { return false; } }
    }
}
