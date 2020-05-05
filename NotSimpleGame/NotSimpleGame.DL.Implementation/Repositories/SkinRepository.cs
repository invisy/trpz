using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class SkinRepository : IRepository<SkinEntity>
    {
        private readonly NotSimpleGameDBContext _dbContext;

        public SkinRepository(NotSimpleGameDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(SkinEntity skin)
        {
            _dbContext.Skins.Add(skin);
        }

        public SkinEntity Get(int id)
        {
            return _dbContext.Skins.FirstOrDefault(skin => skin.Id == id);
        }

        public IEnumerable<SkinEntity> GetList()
        {
            return _dbContext.Skins;
        }

        public void Delete(SkinEntity skin)
        {
            _dbContext.Skins.Remove(skin);
        }
    }
}
