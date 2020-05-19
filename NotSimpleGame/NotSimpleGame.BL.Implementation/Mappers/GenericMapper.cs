using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.BL.Abstraction.Mappers;
using NotSimpleGame.Entities.Enums;
using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.BL.Implementation.Mappers
{
    abstract class GenericMapper<TEntity, TModel> : IMapper<TEntity, TModel>
    {
        public GenericMapper()
        {
        }

        public abstract TModel Map(TEntity entity);
        public abstract TEntity Map(TModel entity);

        public virtual IEnumerable<TModel> Map(IEnumerable<TEntity> entityList)
        {
            List<TModel> list = new List<TModel>();
            foreach (TEntity entity in entityList)
                list.Add(Map(entity));
            return (IEnumerable<TModel>)list;
        }

        public virtual IEnumerable<TEntity> Map(IEnumerable<TModel> entityList)
        {
            List<TEntity> list = new List<TEntity>();
            foreach (TModel model in entityList)
                list.Add(Map(model));
            return (IEnumerable<TEntity>)list;
        }
    }
}
