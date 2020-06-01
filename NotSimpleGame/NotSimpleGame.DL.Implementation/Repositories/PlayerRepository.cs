using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : GenericRepository<PlayerEntity, int>, IPlayerRepository
    {
        public PlayerRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {
        }
    }
}
