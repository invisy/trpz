using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Models.General.Skins
{
    abstract class Skin
    {
        protected float price;
        protected String modelPath;
        public abstract void ActivateAbility();
    }
}
