using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models
{
    public class Player
    {
        public Wallet userWallet { get; set; }
        public Character character { get; set; }

        public Player(int startMoney)
        {
            userWallet = new Wallet(startMoney);
        }

        internal void setSkin(Skin skin)
        {
            character.setSkin(skin);
            userWallet.ChargeOff(skin.Price);
        }

        internal void setWeapon(Weapon weapon)
        {
            character.setWeapon(weapon);
            userWallet.ChargeOff(weapon.Price);
        }
    }
}
