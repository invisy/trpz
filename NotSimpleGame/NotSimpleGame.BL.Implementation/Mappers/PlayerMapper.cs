using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.BL.Abstraction.Mappers;

using NotSimpleGame.Models.Characters;
using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class PlayerMapper : GenericMapper<PlayerEntity, Player>
    {
        private Dictionary<Entities.Enums.CharacterType, Type> charactarTypesDict = 
            new Dictionary<Entities.Enums.CharacterType, Type>();

        private IMapper<SkinEntity, Skin> _skinMapper;
        private IMapper<WeaponEntity, Weapon> _weaponMapper;

        public PlayerMapper(IMapper<SkinEntity, Skin> skinMapper, IMapper<WeaponEntity, Weapon> weaponMapper)
        {
            _skinMapper = skinMapper;
            _weaponMapper = weaponMapper;

            charactarTypesDict.Add(Entities.Enums.CharacterType.ELF, typeof(ElfCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.GNOME, typeof(GnomeCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.MAGICIAN, typeof(MagicianCharacter));
            charactarTypesDict.Add(Entities.Enums.CharacterType.WARRIOR, typeof(WarriorCharacter));
        }
        public override Player Map(PlayerEntity entity)
        {
            Type type = charactarTypesDict[entity.Character];
            Character character = (Character)Activator.CreateInstance(type, entity.Id, _skinMapper.Map(entity.Skin), _weaponMapper.Map(entity.Weapon));
            Player player = (Player)Activator.CreateInstance(typeof(Player), entity.Id, entity.Money, character);

            return player;
        }

        public override PlayerEntity Map(Player player)
        {
            PlayerEntity playerEntity = new PlayerEntity();

            playerEntity.Id = player.Id;
            playerEntity.Money = player.UserWallet.Money;
            playerEntity.Character = (Entities.Enums.CharacterType)player.Character.characterType;
            playerEntity.Skin = _skinMapper.Map(player.Character.Skin);
            playerEntity.Weapon = _weaponMapper.Map(player.Character.Weapon);

            return playerEntity;
        }
    }
}
