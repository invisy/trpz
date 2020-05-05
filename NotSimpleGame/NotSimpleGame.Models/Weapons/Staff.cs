using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Weapons
{
    public class Staff : Weapon
    {
        public override CharacterType characterType { get { return CharacterType.MAGICIAN; } }

        public Staff(String name, float distance, float damage,
                     float price, String modelPath) : base(name, distance, damage, price, modelPath)
        {

        }
        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
