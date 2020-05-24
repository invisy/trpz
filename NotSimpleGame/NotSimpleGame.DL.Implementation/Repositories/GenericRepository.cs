using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity: BaseEntity<int>
    {
        private readonly NotSimpleGameDBContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(NotSimpleGameDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual TEntity Get(int id)
        {
            return _dbSet.FirstOrDefault(entity => entity.Id == id);
        }

        public virtual IEnumerable<TEntity> GetList()
        {
            return _dbSet;
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(this.Get(entity.Id));
        }
    }
}
