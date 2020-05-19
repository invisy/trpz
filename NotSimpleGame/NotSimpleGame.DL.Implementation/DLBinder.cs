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
            container.Register<IWeaponsRepository, WeaponsRepository>();
            container.Register<ISkinsRepository, SkinsRepository>();
            container.Register<IPlayerRepository, PlayerRepository>();
            container.Register<IUnitOfWork, UnitOfWork>();
            container.RegisterSingleton<NotSimpleGameDBContext>();
        }
    }
}
