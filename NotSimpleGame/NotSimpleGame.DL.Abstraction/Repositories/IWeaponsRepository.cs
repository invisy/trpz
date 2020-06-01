using NotSimpleGame.Entities;
using System.Collections.Generic;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface IWeaponsRepository : IRepository<WeaponEntity, int>
    {
        IEnumerable<WeaponEntity> FindAllByCharacter(int character);
    }
}
