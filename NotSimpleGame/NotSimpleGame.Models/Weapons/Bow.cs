using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Weapons
{
    public class Bow : Weapon
    {
        public override CharacterType characterType { get { return CharacterType.ELF; } }

        public Bow(int id, String name, float distance, float damage,
                     uint price, String modelPath) : base(id, name, distance, damage, price, modelPath)
        {

        }

        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
