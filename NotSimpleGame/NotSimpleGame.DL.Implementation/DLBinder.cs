using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Utils;
using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.DL.Implementation.Repositories;

namespace NotSimpleGame.DL.Implementation
{
    public static class DLBinder
    {
        public static void BindDL(this IIoCContainer container)
        {
            container.Register<IRepository<WeaponEntity>, GenericRepository<WeaponEntity>>();
            container.Register<IRepository<SkinEntity>, GenericRepository<SkinEntity>>();
            container.Register<IRepository<PlayerEntity>, GenericRepository<PlayerEntity>>();
            container.Register<IUnitOfWork, UnitOfWork>();
            container.RegisterSingleton<NotSimpleGameDBContext>();
        }
    }
}
