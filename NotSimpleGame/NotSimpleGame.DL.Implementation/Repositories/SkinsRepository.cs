using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NotSimpleGame.Entities.Enums;

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
