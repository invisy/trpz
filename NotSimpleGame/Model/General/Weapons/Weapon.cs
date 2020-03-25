using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Characters;

namespace NotSimpleGame.Models.General.Weapons
{
    public abstract class Weapon
    {
        public String Name { get; set; } //temp
        protected float distance;
        protected float damage;
        public float price; //temp
        protected String modelPath;
        abstract internal Type character { get; }
        internal abstract void Shoot();
    }
}
