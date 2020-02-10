using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Models.General
{
    abstract class Weapon : IWeapon
    {
        public abstract void Shoot();
    }
}
