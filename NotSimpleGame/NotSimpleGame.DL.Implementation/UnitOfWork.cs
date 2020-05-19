using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.DL.Implementation.Repositories;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NotSimpleGameDBContext _dbContext;
        private Dictionary<Type, Object> repositories = new Dictionary<Type, object>();
        public UnitOfWork(NotSimpleGameDBContext dbContext, IPlayerRepository playerRepository,
            IWeaponsRepository weaponsRepository, ISkinsRepository skinsRepository)
        {
            _dbContext = dbContext;
            repositories.Add(typeof(IPlayerRepository), playerRepository);
            repositories.Add(typeof(IWeaponsRepository), weaponsRepository);
            repositories.Add(typeof(ISkinsRepository), skinsRepository);
        }

        public TRepository Repository<TRepository>()
        {
            return (TRepository)repositories[typeof(TRepository)];
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
