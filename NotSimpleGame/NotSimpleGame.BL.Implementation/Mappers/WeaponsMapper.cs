using NotSimpleGame.Entities;
using NotSimpleGame.Models.Weapons;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class WeaponsMapper : GenericMapper<WeaponEntity, Weapon>
    {
        private Dictionary<Entities.Enums.CharacterType, Type> characterTypesDict =
            new Dictionary<Entities.Enums.CharacterType, Type>();

        public WeaponsMapper()
        {
            characterTypesDict.Add(Entities.Enums.CharacterType.ELF, typeof(Bow));
            characterTypesDict.Add(Entities.Enums.CharacterType.GNOME, typeof(Hammer));
            characterTypesDict.Add(Entities.Enums.CharacterType.MAGICIAN, typeof(Staff));
            characterTypesDict.Add(Entities.Enums.CharacterType.WARRIOR, typeof(Sword));
        }
        public override Weapon Map(WeaponEntity entity)
        {
            Type type = characterTypesDict[entity.Character];
            Weapon weapon = (Weapon)Activator.CreateInstance(type, entity.Id, entity.Name, entity.Distance,
                entity.Damage, entity.Price, entity.ModelPath);
            return weapon;
        }

        public override WeaponEntity Map(Weapon weapon)
        {
            WeaponEntity weaponEntity = new WeaponEntity();

            weaponEntity.Character = (Entities.Enums.CharacterType)weapon.characterType;
            weaponEntity.Id = weapon.Id;
            weaponEntity.ModelPath = weapon.ModelPath;
            weaponEntity.Damage = weapon.Damage;
            weaponEntity.Distance = weapon.Distance;
            weaponEntity.Name = weapon.Name;
            weaponEntity.Price = weapon.Price;

            return weaponEntity;
        }
    }
}
