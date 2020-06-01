using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using System;

namespace NotSimpleGame.Models.Characters
{
    public class ElfCharacter : Character
    {
        public override String Name { get { return "Ельф"; } }
        public override CharacterType characterType { get { return CharacterType.ELF; } }

        public override int health { get { return 200; } }
        public override int moveSpeed { get { return 100; } }
        public override int jumpHeight { get { return 100; } }

        public ElfCharacter() : base()
        {
        }

        public ElfCharacter(int id, Skin skin, Weapon weapon) : base(id, skin, weapon)
        {
        }

        override public void Jump()
        {
            throw new NotImplementedException();
        }

        override public void Move()
        {
            throw new NotImplementedException();
        }
        override public void Attack()
        {
            throw new NotImplementedException();
        }
        override public void Defend()
        {
            throw new NotImplementedException();
        }


    }
}
