using System.Collections.Generic;

namespace NotSimpleGame.Entities
{
    public class PlayerEntity : BaseEntity<int>
    {
        public int Health { get; set; }
        public uint Money { get; set; }
        public int CharacterId { get; set; }
        public int WeaponId { get; set; }
        public int SkinId { get; set; }
        public CharacterEntity Character { get; set; }
        public WeaponEntity Weapon { get; set; }
        public SkinEntity Skin { get; set; }
    }
}
