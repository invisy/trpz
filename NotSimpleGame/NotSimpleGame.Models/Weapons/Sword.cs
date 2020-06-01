using NotSimpleGame.Models.Characters;
using System;

namespace NotSimpleGame.Models.Weapons
{
    public class Sword : Weapon
    {
        public override CharacterType characterType { get { return CharacterType.WARRIOR; } }

        public Sword(int id, String name, float distance, float damage,
                     uint price, String modelPath) : base(id, name, distance, damage, price, modelPath)
        {

        }

        override internal void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
