using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NotSimpleGame.Models.General.Characters;

namespace NotSimpleGame.Models.General.Weapons
{
    public class Staff : Weapon
    {
        override internal Type character { get { return typeof(MagicianCharacter); } }
        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
