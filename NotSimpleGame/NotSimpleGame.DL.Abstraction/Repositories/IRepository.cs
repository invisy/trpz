using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList();
        T Get(int id);
        void Create(T item);
        void Delete(T item);
        void Update(T item);
    }
}
