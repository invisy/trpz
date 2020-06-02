using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class SkinsMapper : GenericMapper<SkinEntity, Skin>
    {
        public SkinsMapper()
        {

        }

        public override Skin Map(SkinEntity entity)
        {
            Skin skin = new Skin(entity.Id, entity.Name, entity.Price, entity.ModelPath, entity.CharacterId);
            return skin;
        }

        public override SkinEntity Map(Skin skin)
        {
            SkinEntity skinEntity = new SkinEntity();

            skinEntity.CharacterId = skin.SupportedCharacterId;
            skinEntity.Id = skin.Id;
            skinEntity.ModelPath = skin.ModelPath;
            skinEntity.Name = skin.Name;
            skinEntity.Price = skin.Price;

            return skinEntity;
        }
    }
}
