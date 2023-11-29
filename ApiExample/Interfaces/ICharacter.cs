namespace ApiExample.Interfaces
{
    public interface ICharacter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int HeightInInches { get; set; }
        public string SecretIdentity { get; set; }
        public bool IsGood { get; set; }
        public bool IsEvil { get; set; }
        public bool CanFly { get; set; }
    }
}
