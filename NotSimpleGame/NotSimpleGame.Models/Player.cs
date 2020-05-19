using System;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.Models.Skins;

namespace NotSimpleGame.Models
{
    public class Player
    {
        public int Id { get; private set; }
        public Wallet UserWallet { get; private set; }
        public Character Character { get; set; }
        public Player(int id, uint startMoney, Character character)
        {
            Id = id;
            UserWallet = new Wallet(startMoney);
            this.Character = character;
        }

        public void setSkin(Skin skin)
        {
            Character.setSkin(skin);
            UserWallet.ChargeOff(skin.Price);
        }

        public void setWeapon(Weapon weapon)
        {
            Character.setWeapon(weapon);
            UserWallet.ChargeOff(weapon.Price);
        }
    }
}
