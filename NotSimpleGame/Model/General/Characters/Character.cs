using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.Models.General.Characters
{
    public abstract class Character
    {
        protected Vector2 position;
        protected int health;
        protected float money;
        protected int moveSpeed;
        protected int jumpHeight;
        protected Skin skin;
        protected Weapon weapon;

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
        abstract public void setSkin(Skin newskin);
        abstract public void setWeapon(Weapon newweapon);
    }
}
