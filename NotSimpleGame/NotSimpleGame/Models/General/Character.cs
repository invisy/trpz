using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NotSimpleGame.Models.General
{
    abstract class Character : ICharacter
    {
        protected Vector2 position;
        protected int health;
        protected int moveSpeed;
        protected int jumpSpeed;
        protected Weapon weapon; 

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
    }
}
