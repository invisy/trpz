using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Weapons
{
    public class Sword : Weapon
    {
        public override CharacterType characterType { get { return CharacterType.WARRIOR; } }

        public Sword(String name, float distance, float damage,
                     uint price, String modelPath) : base(name, distance, damage, price, modelPath)
        {

        }

        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
