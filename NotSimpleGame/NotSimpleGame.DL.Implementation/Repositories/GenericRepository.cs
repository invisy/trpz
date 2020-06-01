using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class GenericRepository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity: BaseEntity<Tkey> where Tkey : IComparable
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

        public virtual TEntity Get(Tkey id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetList()
        {
            return _dbSet;
        }
        public virtual void Update(TEntity entity)
        {
            TEntity find = this.Get(entity.Id);
            _dbContext.Entry(find).CurrentValues.SetValues(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(this.Get(entity.Id));
        }
    }
}
