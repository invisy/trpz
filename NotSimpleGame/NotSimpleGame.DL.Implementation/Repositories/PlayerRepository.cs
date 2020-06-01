using Microsoft.EntityFrameworkCore;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : GenericRepository<PlayerEntity, int>, IPlayerRepository
    {
        public PlayerRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {
        }
        public override PlayerEntity Get(int id)
        {
            return _dbSet.Include(p => p.Skin).Include(p => p.Weapon).FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<PlayerEntity> GetList()
        {
            return _dbSet.Include(p => p.Skin).Include(p => p.Weapon).ToList();
        }

    }
}
