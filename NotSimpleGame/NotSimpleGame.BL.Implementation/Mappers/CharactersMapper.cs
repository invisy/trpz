using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class CharactersMapper : GenericMapper<CharacterEntity, Character>
    {
        public CharactersMapper()
        {

        }

        public override Character Map(CharacterEntity entity)
        {
            Character character = new Character(entity.Id, entity.Name, entity.MoveSpeed, entity.JumpHeight);
            return character;
        }

        public override CharacterEntity Map(Character character)
        {
            CharacterEntity characterEntity = new CharacterEntity();

            characterEntity.Id = character.Id;
            characterEntity.Name = character.Name;
            characterEntity.MoveSpeed = character.MoveSpeed;
            characterEntity.JumpHeight = character.JumpHeight;


            return characterEntity;
        }
    }
}
