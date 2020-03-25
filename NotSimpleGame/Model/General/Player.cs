using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Weapons;
using NotSimpleGame.Models.General.Skins;

namespace NotSimpleGame.Models.General
{
    public class Player
    {
        public Wallet userWallet { get; private set; }
        public Character character { get; internal set; }

        internal Player()
        {
            userWallet = new Wallet(500);
        }

        internal void setSkin(Skin skin)
        {
            character.setSkin(skin);
            userWallet.ChargeOff(skin.price);
        }

        internal void setWeapon(Weapon weapon)
        {
            character.setWeapon(weapon);
            userWallet.ChargeOff(weapon.price);
        }
    }
}
