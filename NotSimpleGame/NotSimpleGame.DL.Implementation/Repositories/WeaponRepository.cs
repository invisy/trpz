using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class WeaponRepository : IRepository<WeaponEntity>
    {
        private readonly NotSimpleGameDBContext _dbContext;

        public WeaponRepository(NotSimpleGameDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(WeaponEntity weaponEntity)
        {
            _dbContext.Weapons.Add(weaponEntity);
        }

        public WeaponEntity Get(int id)
        {
            return _dbContext.Weapons.FirstOrDefault(weapon => weapon.Id == id);
        }

        public IEnumerable<WeaponEntity> GetList()
        {
            return _dbContext.Weapons;
        }

        public void Delete(WeaponEntity weaponEntity)
        {
            _dbContext.Weapons.Remove(weaponEntity);
        }
    }
}
