using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class WeaponsRepository : GenericRepository<WeaponEntity>, IWeaponsRepository
    {
        public WeaponsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
    }
}
