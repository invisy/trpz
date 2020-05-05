using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Utils;
using NotSimpleGame.Entities;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.DL.Implementation.Repositories;

namespace NotSimpleGame.DL.Implementation
{
    public static class DLBinder
    {
        public static void BindDL(this IIoCContainer container)
        {
            container.Register<IRepository<WeaponEntity>, WeaponRepository>();
            container.Register<IRepository<SkinEntity>, SkinRepository>();
            container.Register<IRepository<PlayerEntity>, PlayerRepository>();
            container.RegisterSingleton<NotSimpleGameDBContext>();
        }
    }
}
