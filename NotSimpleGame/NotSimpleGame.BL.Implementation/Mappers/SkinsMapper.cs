using NotSimpleGame.Entities;
using NotSimpleGame.Models.Skins;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class SkinsMapper : GenericMapper<SkinEntity, Skin>
    {
        private Dictionary<Entities.Enums.CharacterType, Type> characterTypesDict =
            new Dictionary<Entities.Enums.CharacterType, Type>();

        public SkinsMapper()
        {
            characterTypesDict.Add(Entities.Enums.CharacterType.ELF, typeof(ElfSkin));
            characterTypesDict.Add(Entities.Enums.CharacterType.GNOME, typeof(GnomeSkin));
            characterTypesDict.Add(Entities.Enums.CharacterType.MAGICIAN, typeof(MagicianSkin));
            characterTypesDict.Add(Entities.Enums.CharacterType.WARRIOR, typeof(WarriorSkin));
        }

        public override Skin Map(SkinEntity entity)
        {
            Type type = characterTypesDict[entity.Character];
            Skin skin = (Skin)Activator.CreateInstance(type, entity.Id, entity.Name, entity.Price, entity.ModelPath);
            return skin;
        }

        public override SkinEntity Map(Skin skin)
        {
            SkinEntity skinEntity = new SkinEntity();

            skinEntity.Character = (Entities.Enums.CharacterType)skin.characterType;
            skinEntity.Id = skin.Id;
            skinEntity.ModelPath = skin.ModelPath;
            skinEntity.Name = skin.Name;
            skinEntity.Price = skin.Price;

            return skinEntity;
        }
    }
}
