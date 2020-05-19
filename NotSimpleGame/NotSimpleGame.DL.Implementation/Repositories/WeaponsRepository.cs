using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class WeaponsRepository : GenericRepository<WeaponEntity>, IWeaponsRepository
    {
        public WeaponsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<WeaponEntity> FindAllByCharacter(int character)
        {
            IQueryable<WeaponEntity> weaponIQueryable = _dbSet.AsQueryable();
            IQueryable<WeaponEntity> result = weaponIQueryable.Where(weapon => weapon.Character == (CharacterType)character);
            return result;
        }
    }
}
