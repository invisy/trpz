using NotSimpleGame.Entities;
using System.Collections.Generic;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface ISkinsRepository : IRepository<SkinEntity, int>
    {
        IEnumerable<SkinEntity> FindAllByCharacter(int character);
    }
}
