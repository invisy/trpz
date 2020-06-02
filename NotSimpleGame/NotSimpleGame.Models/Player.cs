
using System;

namespace NotSimpleGame.Models
{
    public class Player : BaseModel<int>
    {
        public int Health { get; private set; }
        public Wallet UserWallet { get; private set; }
        public Character SelectedCharacter { get; private set; }
        public Weapon SelectedWeapon { get; private set; }
        public Skin SelectedSkin { get; private set; }
        public Player(int id, uint startMoney, Character character, Skin skin, Weapon weapon)
        {
            Id = id;
            UserWallet = new Wallet(startMoney);
            SelectedCharacter = character;
            SelectedSkin = skin;
            SelectedWeapon = weapon;
        }

        public void setCharacter(Character character)
        {
            if (SelectedSkin != null)
            {
                UserWallet.ChargeOn(SelectedSkin.Price);
            }
            if (SelectedWeapon != null)
            {
                UserWallet.ChargeOn(SelectedWeapon.Price);
            }
            SelectedSkin = null;
            SelectedWeapon = null;
            SelectedCharacter = character;
        }

        public bool setSkin(Skin skin)
        {
            if (skin.SupportedCharacterId == SelectedCharacter.Id)
            {
                bool result = UserWallet.ChargeOff(skin.Price);
                if (!result)
                    return false;
                if (SelectedSkin != null)
                    UserWallet.ChargeOn(SelectedSkin.Price);
                this.SelectedSkin = skin;
                return true;
            }
            else
                throw new Exception("Select right skin!");
        }

        public bool setWeapon(Weapon weapon)
        {
            if (weapon.SupportedCharacterId == SelectedCharacter.Id)
            {
                bool result = UserWallet.ChargeOff(weapon.Price);
                if (!result)
                    return false;
                if (SelectedWeapon != null)
                    UserWallet.ChargeOn(SelectedWeapon.Price);
                this.SelectedWeapon = weapon;
                return true;
            }
            else
                throw new Exception("Select right weapon!");
        }
    }
}
