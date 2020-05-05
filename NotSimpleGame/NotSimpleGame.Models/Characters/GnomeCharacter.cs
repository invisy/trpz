using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models.Characters
{
    public class GnomeCharacter : Character
    {
        public override String Name { get { return "Гном"; } }
        public override CharacterType characterType { get { return CharacterType.GNOME; } }

        public override int health { get { return 250; } }
        public override int moveSpeed { get { return 80; } }
        public override int jumpHeight { get { return 50; } }

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
