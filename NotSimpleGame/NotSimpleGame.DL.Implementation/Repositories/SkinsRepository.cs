using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class SkinsRepository : GenericRepository<SkinEntity>, ISkinsRepository
    {
        public SkinsRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<SkinEntity> FindAllByCharacter(int character)
        {
            IQueryable<SkinEntity> skinIQueryable = _dbSet.AsQueryable();
            IQueryable<SkinEntity> result = skinIQueryable.Where(skin => skin.Character == (CharacterType)character);
            return result;
        }
    }
}
