using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Skins
{
    public abstract class Skin : BaseModel<int>
    {
        abstract public CharacterType characterType { get; }
        public String Name { get; protected set;  }
        public uint Price { get; protected set; }
        public String ModelPath { get; protected set; }

        public Skin(int id, String name, uint price, String modelPath)
        {
            Id = id;
            Name = name;
            Price = price;
            ModelPath = modelPath;
        }

        internal abstract void ActivateAbility();
    }
}
