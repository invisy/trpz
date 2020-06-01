using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class WeaponsRepository : GenericRepository<WeaponEntity, int>, IWeaponsRepository
    {
        public WeaponsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<WeaponEntity> FindAllByCharacter(int character)
        {
            IQueryable<WeaponEntity> result = _dbSet.AsQueryable().Where(weapon => weapon.Character == (CharacterType)character);
            return result.ToList();
        }
    }
}
