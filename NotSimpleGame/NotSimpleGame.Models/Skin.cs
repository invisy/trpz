using System;

namespace NotSimpleGame.Models
{
    public class Skin : BaseModel<int>
    {
        public String Name { get; private set; }
        public uint Price { get; private set; }
        public String ModelPath { get; private set; }
        public int SupportedCharacterId { get; private set; }

        public Skin(int id, String name, uint price, String modelPath, int supportedCharacterId)
        {
            Id = id;
            Name = name;
            Price = price;
            ModelPath = modelPath;
            SupportedCharacterId = supportedCharacterId;
        }
    }
}
