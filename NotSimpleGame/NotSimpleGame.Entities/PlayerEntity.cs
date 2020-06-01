
using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.Entities
{
    public class PlayerEntity : BaseEntity<int>
    {
        public uint Money { get; set; }
        public int SkinId { get; set; }
        public int WeaponId { get; set; }
        public SkinEntity Skin { get; set; }
        public WeaponEntity Weapon { get; set; }
        public CharacterType Character { get; set; }
    }
}
