using NotSimpleGame.BL.Abstraction.Mappers;
using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using System;
using System.Collections.Generic;


namespace NotSimpleGame.BL.Implementation.Mappers
{
    class PlayerMapper : GenericMapper<PlayerEntity, Player>
    {
        private IMapper<CharacterEntity, Character> _characterMapper;
        private IMapper<SkinEntity, Skin> _skinMapper;
        private IMapper<WeaponEntity, Weapon> _weaponMapper;

        public PlayerMapper(IMapper<CharacterEntity, Character> characterMapper, IMapper<SkinEntity,
            Skin> skinMapper, IMapper<WeaponEntity, Weapon> weaponMapper)
        {
            _characterMapper = characterMapper;
            _skinMapper = skinMapper;
            _weaponMapper = weaponMapper;
        }
        public override Player Map(PlayerEntity entity)
        {
            Character character = _characterMapper.Map(entity.Character);
            Skin skin = _skinMapper.Map(entity.Skin);
            Weapon weapon = _weaponMapper.Map(entity.Weapon);
            Player player = new Player(entity.Id, entity.Money, character, skin, weapon);
            return player;
        }

        public override PlayerEntity Map(Player player)
        {
            PlayerEntity playerEntity = new PlayerEntity();

            playerEntity.Id = player.Id;
            playerEntity.Money = player.UserWallet.Money;
            playerEntity.CharacterId = player.SelectedCharacter.Id;
            playerEntity.SkinId = player.SelectedSkin.Id;
            playerEntity.WeaponId = player.SelectedWeapon.Id;

            return playerEntity;
        }
    }
}
