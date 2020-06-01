using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using System;

namespace NotSimpleGame.Models.Characters
{
    public class GnomeCharacter : Character
    {
        public override String Name { get { return "Гном"; } }
        public override CharacterType characterType { get { return CharacterType.GNOME; } }

        public override int health { get { return 250; } }
        public override int moveSpeed { get { return 80; } }
        public override int jumpHeight { get { return 50; } }

        public GnomeCharacter() : base()
        {
        }
        public GnomeCharacter(int id, Skin skin, Weapon weapon) : base(id, skin, weapon)
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
