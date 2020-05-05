using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : IRepository<PlayerEntity>
    {
        private readonly NotSimpleGameDBContext _dbContext;

        public PlayerRepository(NotSimpleGameDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(PlayerEntity PlayerEntity)
        {
            _dbContext.Players.Add(PlayerEntity);
        }

        public PlayerEntity Get(int id)
        {
            return _dbContext.Players.FirstOrDefault(player => player.Id == id);
        }

        public IEnumerable<PlayerEntity> GetList()
        {
            return _dbContext.Players;
        }

        public void Delete(PlayerEntity PlayerEntity)
        {
            _dbContext.Players.Remove(PlayerEntity);
        }
    }
}
