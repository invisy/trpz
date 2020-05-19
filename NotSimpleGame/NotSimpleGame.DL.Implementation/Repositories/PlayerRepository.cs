using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : GenericRepository<PlayerEntity>, IPlayerRepository
    {
        public PlayerRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
    }
}
