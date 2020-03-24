using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DataLayer.Repositories
{
    class WeaponRepository : IRepository<Weapon>
    {
        private List<Weapon> _weapons = new List<Weapon>();

        public void Create(Weapon weapon)
        {
            _weapons.Add(weapon);
        }

        public Weapon Get(int id)
        {
            return new Weapon();
        }

        public IEnumerable<Weapon> GetList()
        {
            return _weapons;
        }

        public void Delete(int id)
        {

        }

        public void Update(Weapon weapon)
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
