using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Skins
{
    public class WarriorSkin : Skin
    {
        public override CharacterType characterType { get { return CharacterType.WARRIOR; } }

        public WarriorSkin(int id, String name, uint price, String modelPath) : base(id, name, price, modelPath)
        {

        }

        override internal void ActivateAbility()
        {
            throw new NotImplementedException();
        }
    }
}
