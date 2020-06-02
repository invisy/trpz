using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    class WeaponsMapper : GenericMapper<WeaponEntity, Weapon>
    {
        public WeaponsMapper()
        {
        }
        public override Weapon Map(WeaponEntity entity)
        {
            Weapon weapon = new Weapon(entity.Id, entity.Name, entity.Distance,
                entity.Damage, entity.Price, entity.ModelPath, entity.CharacterId);
            return weapon;
        }

        public override WeaponEntity Map(Weapon weapon)
        {
            WeaponEntity weaponEntity = new WeaponEntity();

            weaponEntity.CharacterId = weapon.SupportedCharacterId;
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
