using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    public class UnitOfWork
    {
        private readonly NotSimpleGameDBContext _dbContext;
        public Dictionary<Type, Object> repositories = new Dictionary<Type, object>();
        public UnitOfWork(NotSimpleGameDBContext dbContext, IRepository<PlayerEntity> playerRepository, 
            IRepository<WeaponEntity> weaponsRepository, IRepository<SkinEntity> skinsRepository)
        {
            _dbContext = dbContext;
            repositories.Add(typeof(IRepository<PlayerEntity>), playerRepository);
            repositories.Add(typeof(IRepository<WeaponEntity>), weaponsRepository);
            repositories.Add(typeof(IRepository<SkinEntity>), skinsRepository);
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            return (IRepository<TEntity>)repositories[typeof(IRepository<TEntity>)];
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
