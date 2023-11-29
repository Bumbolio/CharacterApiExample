using ApiExample.Interfaces;

namespace ApiExample.Classes
{
    public abstract class CharacterBase : ICharacter
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int HeightInInches { get; set; }
        public string SecretIdentity { get; set; }
        public virtual bool IsGood { get; set; }
        public virtual bool IsEvil { get; set; }
        public bool CanFly { get; set; }
    }
}
