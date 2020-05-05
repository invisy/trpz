using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Skins
{
    public class ElfSkin : Skin
    {
        public override CharacterType characterType { get { return CharacterType.ELF; } }

        public ElfSkin(String name, float price, String modelPath) : base(name, price, modelPath)
        {

        }

        override internal void ActivateAbility()
        {
            throw new NotImplementedException();
        }
    }
}
