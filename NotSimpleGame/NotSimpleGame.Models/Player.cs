using System;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models
{
    public class Player
    {
        public Wallet userWallet { get; set; }
        public Character character { get; set; }

        public Player(uint startMoney)
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
