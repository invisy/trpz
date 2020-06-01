using NotSimpleGame.Models.Characters;
using System;

namespace NotSimpleGame.Models.Skins
{
    public class MagicianSkin : Skin
    {
        public override CharacterType characterType { get { return CharacterType.MAGICIAN; } }

        public MagicianSkin(int id, String name, uint price, String modelPath) : base(id, name, price, modelPath)
        {

        }

        override internal void ActivateAbility()
        {
            throw new NotImplementedException();
        }
    }
}
