using System;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models
{
    public class Player : BaseModel<int>
    {
        public Wallet UserWallet { get; private set; }
        public Character Character { get; private set; }
        public Player(int id, uint startMoney, Character character)
        {
            Id = id;
            UserWallet = new Wallet(startMoney);
            this.Character = character;
        }

        public void setCharacter(Character character)
        {
            if (Character.Skin != null)
            {
                UserWallet.ChargeOn(Character.Skin.Price);
            }
            if (Character.Weapon != null)
            {
                UserWallet.ChargeOn(Character.Weapon.Price);
            }
            Character.toDefault();
            Character = character;
        }

        public bool setSkin(Skin skin)
        {
            bool result = UserWallet.ChargeOff(skin.Price);
            if (!result)
                return false;
            if (Character.Skin != null)
                UserWallet.ChargeOn(Character.Skin.Price);
            Character.setSkin(skin);
            return true;
        }

        public bool setWeapon(Weapon weapon)
        {
            bool result = UserWallet.ChargeOff(weapon.Price);
            if (!result)
                return false;
            if(Character.Weapon != null)
                UserWallet.ChargeOn(Character.Weapon.Price);
            Character.setWeapon(weapon);
            return true;
        }
    }
}
