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
        public int Id { get; protected set; }
        public Vector2 position { get; protected set; }
        public abstract int health { get; }
        public abstract int moveSpeed { get; }
        public abstract int jumpHeight { get; }
        public Skin Skin { get; protected set; }
        public Weapon Weapon { get; protected set; }

        abstract public String Name { get; }
        abstract public CharacterType characterType { get; }

        public Character()
        {

        }

        public Character(int id, Skin skin, Weapon weapon)
        {
            Id = id;
            if (skin != null && weapon != null)
            {
                this.setSkin(skin);
                this.setWeapon(weapon);
            }
        }

        internal void setSkin(Skin newskin)
        {
            if (newskin.characterType == characterType)
                this.Skin = newskin;
            else
                throw new Exception("Select right skin!");
        }

        internal void setWeapon(Weapon newweapon)
        {
            if (newweapon.characterType == characterType)
                this.Weapon = newweapon;
            else
                throw new Exception("Select right weapon!");
        }

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
    }
}
