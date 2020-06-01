using System;
using System.Collections.Generic;
using System.Text;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface IPlayerRepository : IRepository<PlayerEntity, int>
    {
    }
}
