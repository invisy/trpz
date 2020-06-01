using NotSimpleGame.Entities.Enums;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.Entities
{
    public class SkinEntity : BaseEntity<int>
    {
        public SkinEntity()
        {
            Players = new HashSet<PlayerEntity>();
        }

        public String Name { get; set; }
        public uint Price { get; set; }
        public String ModelPath { get; set; }
        public CharacterType Character { get; set; }
        public IEnumerable<PlayerEntity> Players { get; set; }
    }
}
