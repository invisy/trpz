using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Abstraction
{
    public interface IUnitOfWork
    {
        public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        public void Save();
    }
}
