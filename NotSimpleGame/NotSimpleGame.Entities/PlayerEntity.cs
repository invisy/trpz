using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.Entities
{
    public class PlayerEntity : BaseEntity<int>
    {
        public uint Money { get; set; }
        public int SkinId { get; set; }
        public int WeaponId { get; set; }
        public CharacterType Character { get; set; }
    }
}
