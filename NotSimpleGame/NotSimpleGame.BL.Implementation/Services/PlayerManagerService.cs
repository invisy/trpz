using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Weapons;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.BL.Abstraction;
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

            characters.Add(new ElfCharacter());
            characters.Add(new GnomeCharacter());
            characters.Add(new MagicianCharacter());
            characters.Add(new WarriorCharacter());

            player = _playerMapper.Map(_playerRepo.Get(1));

            for (int i=0; i < characters.Count; i++)
            {
                if (characters[i].GetType() == player.Character.GetType())
                    characters[i] = player.Character;
            }
        }

        public IEnumerable<Character> getCharacters()
        {
            return characters;
        }
        public IEnumerable<Weapon> getWeapons(Character selectedCharacter)
        {
            return _weaponsMapper.Map(_weaponRepo.FindAllByCharacter((int)selectedCharacter.characterType));
        }
        public IEnumerable<Skin> getSkins(Character selectedCharacter)
        {
            return _skinsMapper.Map(_skinRepo.FindAllByCharacter((int)selectedCharacter.characterType));
        }
        public Player getPlayerInfo()
        {
            return player;
        }
        public void SavePlayerInfo(Weapon weapon, Skin skin)
        {
            _playerRepo.Update(_playerMapper.Map(player));
            _UoW.Save();
        }
    }
}
