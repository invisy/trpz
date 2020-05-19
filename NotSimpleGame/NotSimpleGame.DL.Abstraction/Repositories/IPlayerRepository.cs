using System;
using System.Collections.Generic;
using System.Text;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface IPlayerRepository
    {
        IEnumerable<PlayerEntity> GetList();
        PlayerEntity Get(int id);
        void Update(PlayerEntity item);
    }
}
