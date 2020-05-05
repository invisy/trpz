using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : IRepository<PlayerEntity>
    {
        private List<PlayerEntity> _PlayerEntitys = new List<PlayerEntity>();

        public PlayerRepository()
        {
            PlayerEntity PlayerEntity = new PlayerEntity();
            PlayerEntity.money = 500;
            _PlayerEntitys.Add(PlayerEntity);
        }

        public void Create(PlayerEntity PlayerEntity)
        {
            _PlayerEntitys.Add(PlayerEntity);
        }

        public PlayerEntity Get(int id)
        {
            return new PlayerEntity();
        }

        public IEnumerable<PlayerEntity> GetList()
        {
            return _PlayerEntitys;
        }

        public void Delete(int id)
        {

        }

        public void Update(PlayerEntity PlayerEntity)
        {
        }

        public void Save()
        {

        }

        public void Dispose()
        {
        }
    }
}
