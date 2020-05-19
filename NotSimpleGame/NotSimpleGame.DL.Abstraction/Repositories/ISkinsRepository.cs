using System;
using System.Collections.Generic;
using System.Text;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface ISkinsRepository
    {
        IEnumerable<SkinEntity> GetList();
        SkinEntity Get(int id);
    }
}
