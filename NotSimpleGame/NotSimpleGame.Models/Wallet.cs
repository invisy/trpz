using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Models
{
    public class Wallet
    {
        private float money;
        public float Money { get { return money; } }

        internal Wallet(float value)
        {
            if (value >= 0)
                money = value;
        }

        internal bool ChargeOff(float value)
        {
            if(value >= 0 && money >= value)
            {
                money -= value;
                return true;
            }
            else
                return false;
        }

        internal bool ChargeOn(float value)
        {
            if (value >= 0)
            {
                money += value;
                return true;
            }
            else
                return false;
        }   
    }
}
