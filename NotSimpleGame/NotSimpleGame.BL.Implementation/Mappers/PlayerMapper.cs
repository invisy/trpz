using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.BL.Abstraction.Mappers;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.DL.Implementation.Repositories;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class PlayerMapper : GenericMapper<PlayerEntity, Player>
    {
        private Dictionary<Entities.Enums.CharacterType, Type> charactarTypesDict = 
            new Dictionary<Entities.Enums.CharacterType, Type>();
        private readonly IUnitOfWork _uof;

        private IMapper<SkinEntity, Skin> _skinMapper;
        private IMapper<WeaponEntity, Weapon> _weaponMapper;

        public PlayerMapper(IUnitOfWork uof, IMapper<SkinEntity, Skin> skinMapper, IMapper<WeaponEntity, Weapon> weaponMapper)
        {
            _skinMapper = skinMapper;
            _weaponMapper = weaponMapper;
            _uof = uof;

            charactarTypesDict.Add(Entities.Enums.CharacterType.ELF, typeof(ElfCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.GNOME, typeof(GnomeCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.MAGICIAN, typeof(MagicianCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.WARRIOR, typeof(WarriorCharacter));
        }
        public override Player Map(PlayerEntity entity)
        {
            Type type = charactarTypesDict[entity.Character];

            SkinEntity skinEntity = _uof.Repository<ISkinsRepository>().Get(entity.SkinId);
            Skin skin = _skinMapper.Map(skinEntity);
            WeaponEntity weaponEntity = _uof.Repository<IWeaponsRepository>().Get(entity.WeaponId);
            Weapon weapon = _weaponMapper.Map(weaponEntity);

            Character character = (Character)Activator.CreateInstance(type, entity.Id, skin, weapon);
            Player player = (Player)Activator.CreateInstance(typeof(Player), entity.Id, entity.Money, character);
            return player;
        }

        public override PlayerEntity Map(Player player)
        {
            PlayerEntity playerEntity = new PlayerEntity();

            playerEntity.Id = player.Id;
            playerEntity.Money = player.UserWallet.Money;
            playerEntity.Character = (Entities.Enums.CharacterType)player.Character.characterType;

            playerEntity.WeaponId = player.Character.Weapon.Id;
            playerEntity.SkinId = player.Character.Skin.Id;

            return playerEntity;
        }
    }
}
