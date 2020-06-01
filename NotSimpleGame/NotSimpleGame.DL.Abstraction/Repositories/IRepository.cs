using NotSimpleGame.Entities;
using System.Collections.Generic;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface IRepository<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        IEnumerable<TEntity> GetList();
        TEntity Get(Tkey id);
        void Create(TEntity item);
        void Delete(TEntity item);
        void Update(TEntity item);
    }
}
