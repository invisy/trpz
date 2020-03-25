using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Characters;

namespace NotSimpleGame.Models.General.Skins
{
    public abstract class Skin
    {
        public String Name { get; set; } //temp
        public float price; //temp
        protected String modelPath;
        abstract internal Type character { get; }
        internal abstract void ActivateAbility();
    }
}
