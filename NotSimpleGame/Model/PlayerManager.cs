using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Repositories;
using NotSimpleGame.Models.General;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.Models
{
    public class PlayerManager : IPlayerManager
    {
        private WeaponRepository _weaponRepo;
        private SkinRepository _skinRepo;

        private Player player = new Player();                                 // temp, bcs of repository haven`t done yet
        private List<Character> characters = new List<Character>();
        private List<Weapon> weapons = new List<Weapon>();
        private List<Skin> skins = new List<Skin>();                   // >

        public PlayerManager(WeaponRepository weaponRepo, SkinRepository skinRepo)
        {
            this._weaponRepo = weaponRepo;
            this._skinRepo = skinRepo;

            GnomeCharacter charackter = new GnomeCharacter();
            MagicianCharacter charackter2 = new MagicianCharacter();
            characters.Add(charackter);
            characters.Add(charackter2);

            List<Weapon> c = new List<Weapon>();
            Staff weap = new Staff();
            weap.Name = "Стандартний посох";
            weap.price = 0;
            Hammer weap2 = new Hammer();
            weap2.Name = "Стандартний молот";
            weap2.price = 0;
            Staff weap3 = new Staff();
            weap3.Name = "Дерев'яний посох";
            weap3.price = 100;
            Hammer weap4 = new Hammer();
            weap4.Name = "Дерев'яний молот";
            weap4.price = 120;
            weapons.Add(weap);
            weapons.Add(weap2);
            weapons.Add(weap3);
            weapons.Add(weap4);

            GnomeSkin skin1 = new GnomeSkin();
            skin1.Name = "Стандартний вигляд";
            skin1.price = 0;
            MagicianSkin skin2 = new MagicianSkin();
            skin2.Name = "Стандартний вигляд";
            skin2.price = 0;
            GnomeSkin skin3 = new GnomeSkin();
            skin3.Name = "Водяний гном";
            skin3.price = 200;
            MagicianSkin skin4 = new MagicianSkin();
            skin4.Name = "Вогняний маг";
            skin4.price = 250;

            skins.Add(skin1);
            skins.Add(skin2);
            skins.Add(skin3);
            skins.Add(skin4);
        }

        public IEnumerable<Character> getCharacters()
        {
            return characters;
        }
        public IEnumerable<Weapon> getWeapons(Character selectedCharacter)
        {
            IEnumerable<Weapon> result = weapons.Where(skin => skin.character.Equals(selectedCharacter.GetType()));
            return result;
        }
        public IEnumerable<Skin> getSkins(Character selectedCharacter)
        {
            IEnumerable<Skin> result = skins.Where(skin => skin.character.Equals(selectedCharacter.GetType()));
            return result;
        }
        public Player getPlayerInfo()
        {
            return player;
        }
        public void SavePlayerInfo(Character character, Weapon weapon, Skin skin)
        {
            if (weapon.price + skin.price < player.userWallet.Money)
            {
                player.character = character;
                player.setSkin(skin);
                player.setWeapon(weapon);
            }
            else
                throw new Exception("Error");
        }
    }
}
