using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.Entities
{
    public class SkinEntity : BaseEntity<int>
    {
        public String Name { get; set; }
        public uint Price { get; set; }
        public String ModelPath { get; set; }
        public CharacterType Character { get; set; }
    }
}
