using NotSimpleGame.Entities.Enums;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.Entities
{
    public class WeaponEntity : BaseEntity<int>
    {
        public WeaponEntity()
        {
            Players = new HashSet<PlayerEntity>();
        }

        public String Name { get; set; }
        public float Distance { get; set; }
        public float Damage { get; set; }
        public uint Price { get; set; }
        public String ModelPath { get; set; }
        public CharacterType Character { get; set; }
        public IEnumerable<PlayerEntity> Players { get; set; }
    }
}
