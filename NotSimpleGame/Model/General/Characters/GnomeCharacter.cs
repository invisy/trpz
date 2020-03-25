using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Weapons;
using NotSimpleGame.Models.General.Skins;

namespace NotSimpleGame.Models.General.Characters
{
    public class GnomeCharacter : Character
    {
        public override String Name { get { return "Гном"; } }
        internal override void setSkin(Skin newskin)
        {
            if (newskin is GnomeSkin)
                this.skin = newskin;
            else
                throw new Exception("This skin isn`t for gnome!");
        }

        internal override void setWeapon(Weapon newweapon)
        {
            if (newweapon is Hammer)
                this.weapon = newweapon;
            else
                throw new Exception("This weapon isn`t for gnome!");
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
