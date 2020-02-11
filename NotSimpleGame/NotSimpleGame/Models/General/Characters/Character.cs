using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using NotSimpleGame.Models.General.Weapons;
using NotSimpleGame.Models.General.Skins;

namespace NotSimpleGame.Models.General.Characters
{
    abstract class Character
    {
        protected Vector2 position;
        protected int health;
        protected float money;
        protected int moveSpeed;
        protected int jumpHeight;
        protected Weapon weapon;
        protected Skin skin;

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
    }
}
