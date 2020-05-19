using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.BL.Abstraction;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.BL.Implementation.Services
{
    public class PlayerManagerService : IPlayerManager
    {
        private IWeaponsRepository _weaponRepo;
        private ISkinsRepository _skinRepo;

        private Player player = new Player(500);    // temp, bcs of repository haven`t done yet
        private List<Character> characters = new List<Character>();
        private List<Weapon> weapons = new List<Weapon>();
        private List<Skin> skins = new List<Skin>();                   // >

        public PlayerManagerService(IUnitOfWork uow)
        {
            this._weaponRepo = uow.Repository<IWeaponsRepository>();
            this._skinRepo = uow.Repository<ISkinsRepository>();

            GnomeCharacter charackter1 = new GnomeCharacter();
            MagicianCharacter charackter2 = new MagicianCharacter();
            

            GnomeSkin skin1 = new GnomeSkin("Стандартний вигляд", 0, "");
            MagicianSkin skin2 = new MagicianSkin("Стандартний вигляд", 0, "");
            GnomeSkin skin3 = new GnomeSkin("Вогняний гном", 50, "");
            MagicianSkin skin4 = new MagicianSkin("Водяний маг", 100, "");

            Hammer weapon1 = new Hammer("Стандартний молот", 0, 0, 0, "");
            Staff weapon2 = new Staff("Стандартний посох", 0, 0, 0, "");
            Hammer weapon3 = new Hammer("Золотий молот", 0, 0, 280, "");
            Staff weapon4 = new Staff("Золотий посох", 0, 0, 370, "");

            characters.Add(charackter1);
            characters.Add(charackter2);
            skins.Add(skin1);
            skins.Add(skin2);
            skins.Add(skin3);
            skins.Add(skin4);
            weapons.Add(weapon1);
            weapons.Add(weapon2);
            weapons.Add(weapon3);
            weapons.Add(weapon4);

        }

        public IEnumerable<Character> getCharacters()
        {
            return characters;
        }
        public IEnumerable<Weapon> getWeapons(Character selectedCharacter)
        {
            IEnumerable<Weapon> result = weapons.Where(skin => skin.characterType == selectedCharacter.characterType);
            return result;
        }
        public IEnumerable<Skin> getSkins(Character selectedCharacter)
        {
            IEnumerable<Skin> result = skins.Where(skin => skin.characterType == selectedCharacter.characterType);
            return result;
        }
        public Player getPlayerInfo()
        {
            return player;
        }
        public void SavePlayerInfo(Character character, Weapon weapon, Skin skin)
        {
            if (weapon.Price + skin.Price < player.userWallet.Money)
            {
                //OK
            }
            else
                throw new Exception("Error");
        }
    }
}
