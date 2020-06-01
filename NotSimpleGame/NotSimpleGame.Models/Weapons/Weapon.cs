using NotSimpleGame.Models.Characters;
using System;

namespace NotSimpleGame.Models.Weapons
{
    public abstract class Weapon : BaseModel<int>
    {
        abstract public CharacterType characterType { get; }
        public String Name { get; protected set; }
        public float Distance { get; protected set; }
        public float Damage { get; protected set; }
        public uint Price { get; protected set; }
        public String ModelPath { get; protected set; }

        public Weapon(int id, String name, float distance, float damage, uint price, String modelPath)
        {
            Id = id;
            Name = name;
            Distance = distance;
            Damage = damage;
            Price = price;
            ModelPath = modelPath;
        }
        internal abstract void Shoot();
    }
}
