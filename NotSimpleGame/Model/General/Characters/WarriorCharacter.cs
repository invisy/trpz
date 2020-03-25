using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Weapons;
using NotSimpleGame.Models.General.Skins;

namespace NotSimpleGame.Models.General.Characters
{
    public class WarriorCharacter : Character
    {
        public override String Name { get { return "Воїн"; } }
        internal override void setSkin(Skin newskin)
        {
            if (newskin is WarriorSkin)
                this.skin = newskin;
            else
                throw new Exception("This skin isn`t for warrior!");
        }

        internal override void setWeapon(Weapon newweapon)
        {
            if (newweapon is Sword)
                this.weapon = newweapon;
            else
                throw new Exception("This weapon isn`t for warrior!");
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
