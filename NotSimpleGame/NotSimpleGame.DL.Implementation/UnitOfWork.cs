using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.DL.Implementation.Repositories;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    class UnitOfWork
    {
        private readonly NotSimpleGameDBContext _dbContext;
        public IRepository<PlayerEntity> _playerReposiory { get; private set; }
        public IRepository<WeaponEntity> _weaponsReposiory { get; private set; }
        public IRepository<SkinEntity> _skinsReposiory { get; private set; }

        public UnitOfWork(NotSimpleGameDBContext dbContext, IRepository<PlayerEntity> playerRepository, 
            IRepository<WeaponEntity> weaponsReposiory, IRepository<SkinEntity> skinsReposiory)
        {
            _dbContext = dbContext;
            _playerReposiory = playerRepository;
            _weaponsReposiory = weaponsReposiory;
            _skinsReposiory = skinsReposiory;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
