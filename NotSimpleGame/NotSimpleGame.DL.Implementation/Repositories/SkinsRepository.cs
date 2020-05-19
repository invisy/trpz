using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class SkinsRepository : GenericRepository<SkinEntity>, ISkinsRepository
    {
        public SkinsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
    }
}
