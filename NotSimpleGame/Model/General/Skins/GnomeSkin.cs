using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NotSimpleGame.Models.General.Characters;

namespace NotSimpleGame.Models.General.Skins
{
    public class GnomeSkin : Skin
    {
        override internal Type character { get { return typeof(GnomeCharacter); } }
        override internal void ActivateAbility()
        {
            throw new NotImplementedException();
        }
    }
}
