using System;

namespace NotSimpleGame.Models
{
    public class Weapon : BaseModel<int>
    {
        public String Name { get; private set; }
        public float Distance { get; private set; }
        public float Damage { get; private set; }
        public uint Price { get; private set; }
        public String ModelPath { get; private set; }
        public int SupportedCharacterId { get; private set; }

        public Weapon(int id, String name, float distance, float damage, uint price, String modelPath, int supportedCharacterId)
        {
            Id = id;
            Name = name;
            Distance = distance;
            Damage = damage;
            Price = price;
            ModelPath = modelPath;
            SupportedCharacterId = supportedCharacterId;
        }
    }
}
