using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using NotSimpleGame.Entities.Enums;
using System.Collections.Generic;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class SkinsRepository : GenericRepository<SkinEntity, int>, ISkinsRepository
    {
        public SkinsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<SkinEntity> FindAllByCharacter(int character)
        {
            IQueryable<SkinEntity> result = _dbSet.AsQueryable().Where(skin => skin.Character == (CharacterType)character);
            return result.ToList();
        }
    }
}
