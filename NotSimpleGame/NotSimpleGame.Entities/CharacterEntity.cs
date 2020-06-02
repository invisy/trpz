using System;
using System.Collections.Generic;
using System.Text;

namespace NotSimpleGame.Entities
{
    public class CharacterEntity : BaseEntity<int>
    {
        public CharacterEntity()
        {
            Players = new HashSet<PlayerEntity>();
        }

        public string Name { get; set; }
        public int MoveSpeed { get; set; }
        public int JumpHeight { get; set; }
        public IEnumerable<PlayerEntity> Players { get; set; }
    }
}
