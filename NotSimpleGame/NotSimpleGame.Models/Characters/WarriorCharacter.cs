using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models.Characters
{
    public class WarriorCharacter : Character
    {
        public override String Name { get { return "Воїн"; } }
        public override CharacterType characterType { get { return CharacterType.WARRIOR; } }

        public override int health { get { return 120; } }
        public override int moveSpeed { get { return 120; } }
        public override int jumpHeight { get { return 120; } }

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
