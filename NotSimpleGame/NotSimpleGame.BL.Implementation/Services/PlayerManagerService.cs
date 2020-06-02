using NotSimpleGame.BL.Abstraction;
using NotSimpleGame.BL.Abstraction.Mappers;
using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Services
{
    public class PlayerManagerService : IPlayerManager
    {
        IUnitOfWork _UoW;
        private IWeaponsRepository _weaponRepo;
        private ISkinsRepository _skinRepo;
        private IPlayerRepository _playerRepo;
        private ICharactersRepository _characterRepo;

        private IMapper<SkinEntity, Skin> _skinsMapper;
        private IMapper<WeaponEntity, Weapon> _weaponsMapper;
        private IMapper<PlayerEntity, Player> _playerMapper;
        IMapper<CharacterEntity, Character> _characterMapper;

        Player player;

        public PlayerManagerService(IUnitOfWork UoW, IMapper<CharacterEntity, Character> characterMapper, IMapper<SkinEntity, Skin> skinsMapper,
            IMapper<WeaponEntity, Weapon> weaponsMapper, IMapper<PlayerEntity, Player> playerMapper)
        {
            this._UoW = UoW;
            this._weaponRepo = UoW.Repository<IWeaponsRepository>();
            this._skinRepo = UoW.Repository<ISkinsRepository>();
            this._playerRepo = UoW.Repository<IPlayerRepository>();
            this._characterRepo = UoW.Repository<ICharactersRepository>();

            this._skinsMapper = skinsMapper;
            this._weaponsMapper = weaponsMapper;
            this._playerMapper = playerMapper;
            this._characterMapper = characterMapper;

            player = _playerMapper.Map(_playerRepo.Get(1));
        }

        public IEnumerable<Character> getCharacters()
        {
            return _characterMapper.Map(_characterRepo.GetList());
        }
        public IEnumerable<Weapon> getWeapons(Character selectedCharacter)
        {
            return _weaponsMapper.Map(_weaponRepo.FindAllByCharacter((int)selectedCharacter.Id));
        }
        public IEnumerable<Skin> getSkins(Character selectedCharacter)
        {
            return _skinsMapper.Map(_skinRepo.FindAllByCharacter((int)selectedCharacter.Id));
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
