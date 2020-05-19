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

using NotSimpleGame.BL.Implementation.Mappers;

using NotSimpleGame.BL.Abstraction.Mappers;

namespace NotSimpleGame.BL.Implementation.Services
{
    public class PlayerManagerService : IPlayerManager
    {
        IUnitOfWork _UoW;
        private IWeaponsRepository _weaponRepo;
        private ISkinsRepository _skinRepo;
        private IPlayerRepository _playerRepo;

        private IMapper<SkinEntity, Skin> _skinsMapper;
        private IMapper<WeaponEntity, Weapon> _weaponsMapper;
        private IMapper<PlayerEntity, Player> _playerMapper;

        Player player;

        private List<Character> characters = new List<Character>();

        public PlayerManagerService(IUnitOfWork UoW, IMapper<SkinEntity, Skin> skinsMapper, 
            IMapper<WeaponEntity, Weapon> weaponsMapper, IMapper<PlayerEntity, Player> playerMapper)
        {
            this._UoW = UoW;
            this._weaponRepo = UoW.Repository<IWeaponsRepository>();
            this._skinRepo = UoW.Repository<ISkinsRepository>();
            this._playerRepo = UoW.Repository<IPlayerRepository>();

            this._skinsMapper = skinsMapper;
            this._weaponsMapper = weaponsMapper;
            this._playerMapper = playerMapper;

            ElfCharacter elf = new ElfCharacter();
            GnomeCharacter gnome= new GnomeCharacter();
            MagicianCharacter magician = new MagicianCharacter();
            WarriorCharacter warrior = new WarriorCharacter();

            characters.Add(elf);
            characters.Add(gnome);
            characters.Add(magician);
            characters.Add(warrior);

            PlayerEntity ent = _playerRepo.Get(1);
            player = _playerMapper.Map(_playerRepo.Get(1));
            Console.WriteLine(1);
        }

        public IEnumerable<Character> getCharacters()
        {
            return characters;
        }
        public IEnumerable<Weapon> getWeapons(Character selectedCharacter)
        {
            return _weaponsMapper.Map(_weaponRepo.FindAllByCharacter((int)selectedCharacter.characterType)).ToList();
        }
        public IEnumerable<Skin> getSkins(Character selectedCharacter)
        {
            return _skinsMapper.Map(_skinRepo.FindAllByCharacter((int)selectedCharacter.characterType)).ToList();
        }
        public Player getPlayerInfo()
        {
            return player;
        }
        public void SavePlayerInfo(Weapon weapon, Skin skin)
        {
            if (weapon.Price + skin.Price < player.UserWallet.Money)
            {
                _playerRepo.Update(_playerMapper.Map(player));
                _UoW.Save();
            }
            else
                throw new Exception("Error");
        }
    }
}
