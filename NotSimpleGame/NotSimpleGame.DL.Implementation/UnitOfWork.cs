﻿using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using System;
using System.Collections.Generic;

namespace NotSimpleGame.DL.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NotSimpleGameDBContext _dbContext;
        private Dictionary<Type, Object> _repositories = new Dictionary<Type, object>();
        public UnitOfWork(NotSimpleGameDBContext dbContext, IPlayerRepository playerRepository,
            IWeaponsRepository weaponsRepository, ISkinsRepository skinsRepository)
        {
            _dbContext = dbContext;
            _repositories.Add(typeof(IPlayerRepository), playerRepository);
            _repositories.Add(typeof(IWeaponsRepository), weaponsRepository);
            _repositories.Add(typeof(ISkinsRepository), skinsRepository);
        }

        public TRepository Repository<TRepository>()
        {
            if (_repositories.ContainsKey(typeof(TRepository)))
                return (TRepository)_repositories[typeof(TRepository)];
            else
                throw new ArgumentException("Repository doesn`t exist!");
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
