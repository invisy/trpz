using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Skins
{
    public class MagicianSkin : Skin
    {
        public override CharacterType characterType { get { return CharacterType.MAGICIAN; } }

        public MagicianSkin(String name, uint price, String modelPath) : base(name, price, modelPath)
        {

        }

        override internal void ActivateAbility()
        {
            throw new NotImplementedException();
        }
    }
}
