using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;

namespace NotSimpleGame.Models.Characters
{
    public enum CharacterType
    {
        DEFAULT=0,
        ELF,
        GNOME,
        MAGICIAN,
        WARRIOR
    }

    public abstract class Character
    {
        public Vector2 position { get; protected set; }
        public abstract int health { get; }
        public abstract int moveSpeed { get; }
        public abstract int jumpHeight { get; }
        public Skin skin { get; protected set; }
        public Weapon weapon { get; protected set; }

        abstract public String Name { get; }
        abstract public CharacterType characterType { get; }

        internal void setSkin(Skin newskin)
        {
            if (newskin.characterType == characterType)
                this.skin = newskin;
            else
                throw new Exception("Select right skin!");
        }

        internal void setWeapon(Weapon newweapon)
        {
            if (newweapon.characterType == characterType)
                this.weapon = newweapon;
            else
                throw new Exception("Select right weapon!");
        }

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
    }
}
