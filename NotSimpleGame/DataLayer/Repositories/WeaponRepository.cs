using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DataLayer.Repositories
{
    public class WeaponRepository : IRepository<WeaponEntity>
    {
        private List<WeaponEntity> _WeaponEntitys = new List<WeaponEntity>();

        public WeaponRepository()
        {
            WeaponEntity WeaponEntity = new WeaponEntity();
            WeaponEntity.price = 0;

            WeaponEntity WeaponEntity2 = new WeaponEntity();
            WeaponEntity.price = 40;

            _WeaponEntitys.Add(WeaponEntity);
            _WeaponEntitys.Add(WeaponEntity2);
        }

        public void Create(WeaponEntity WeaponEntity)
        {
            _WeaponEntitys.Add(WeaponEntity);
        }

        public WeaponEntity Get(int id)
        {
            return new WeaponEntity();
        }

        public IEnumerable<WeaponEntity> GetList()
        {
            return _WeaponEntitys;
        }

        public void Delete(int id)
        {

        }

        public void Update(WeaponEntity WeaponEntity)
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
