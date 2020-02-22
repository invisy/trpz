using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Models.General.Weapons
{
    abstract class Weapon
    {
        protected float distance;
        protected float damage;
        protected float price;
        protected String modelPath;
        public abstract void Shoot();
    }
}
