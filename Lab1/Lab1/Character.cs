using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Character
    {
        private int health;
        private int speed;

        abstract public void Jump();
        abstract public void Move();
        abstract public void Attack();
        abstract public void Defend();
    }
}
