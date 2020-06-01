namespace NotSimpleGame.Models
{
    public class Wallet
    {
        private uint money;
        public uint Money { get { return money; } }

        internal Wallet(uint value)
        {
            if (value >= 0)
                money = value;
        }

        internal bool ChargeOff(uint value)
        {
            if (value >= 0 && money >= value)
            {
                money -= value;
                return true;
            }
            else
                return false;
        }

        internal bool ChargeOn(uint value)
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
