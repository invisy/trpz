using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DataLayer.Repositories
{
    public class SkinRepository : IRepository<Skin>
    {
        private List<Skin> _skins = new List<Skin>();

        public SkinRepository()
        {
            Skin skin= new Skin();
            skin.price = 0;
            skin.name = "Стандартний лук";

            Skin skin2 = new Skin();
            skin2.price = 40;
            skin2.name = "Дерев'яний лук";

            _skins.Add(skin);
            _skins.Add(skin2);
        }

        public void Create(Skin weapon)
        {
            _skins.Add(weapon);
        }

        public Skin Get(int id)
        {
            return new Skin();
        }

        public IEnumerable<Skin> GetList()
        {
            return _skins;
        }

        public void Delete(int id)
        {

        }

        public void Update(Skin weapon)
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
