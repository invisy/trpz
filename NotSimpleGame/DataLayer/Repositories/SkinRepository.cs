using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DataLayer.Repositories
{
    public class SkinRepository : IRepository<SkinEntity>
    {
        private List<SkinEntity> _SkinEntitys = new List<SkinEntity>();

        public SkinRepository()
        {
            SkinEntity SkinEntity= new SkinEntity();
            SkinEntity.price = 0;
            SkinEntity.name = "Стандартний лук";

            SkinEntity SkinEntity2 = new SkinEntity();
            SkinEntity2.price = 40;
            SkinEntity2.name = "Дерев'яний лук";

            _SkinEntitys.Add(SkinEntity);
            _SkinEntitys.Add(SkinEntity2);
        }

        public void Create(SkinEntity weapon)
        {
            _SkinEntitys.Add(weapon);
        }

        public SkinEntity Get(int id)
        {
            return new SkinEntity();
        }

        public IEnumerable<SkinEntity> GetList()
        {
            return _SkinEntitys;
        }

        public void Delete(int id)
        {

        }

        public void Update(SkinEntity weapon)
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
