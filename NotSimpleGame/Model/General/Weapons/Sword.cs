using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Characters;

namespace NotSimpleGame.Models.General.Weapons
{
    public class Sword : Weapon
    {
        override internal Type character { get { return typeof(WarriorCharacter); } }
        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
