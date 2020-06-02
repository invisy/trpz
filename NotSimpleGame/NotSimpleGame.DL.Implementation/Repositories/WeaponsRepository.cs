using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class WeaponsRepository : GenericRepository<WeaponEntity, int>, IWeaponsRepository
    {
        public WeaponsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<WeaponEntity> FindAllByCharacter(int character)
        {
            IQueryable<WeaponEntity> result = _dbSet.AsQueryable().Where(weapon => weapon.CharacterId == character);
            return result.ToList();
        }
    }
}
