using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Models.General
{
    interface ICharacter
    {
        void Jump();
        void Move();
        void Attack();
        void Defend();
    }
}
