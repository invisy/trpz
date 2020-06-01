
using Microsoft.EntityFrameworkCore;
using NotSimpleGame.DL.Abstraction;
using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.DL.Implementation.Repositories;
using NotSimpleGame.Utils;

namespace NotSimpleGame.DL.Implementation
{
    public static class DLBinder
    {
        public static void BindDL(this IIoCContainer container, string connectionString)
        {
            container.Register<IWeaponsRepository, WeaponsRepository>();
            container.Register<ISkinsRepository, SkinsRepository>();
            container.Register<IPlayerRepository, PlayerRepository>();
            container.Register<IUnitOfWork, UnitOfWork>();

            var optionsBuilder = new DbContextOptionsBuilder<NotSimpleGameDBContext>();
            optionsBuilder.UseSqlServer(connectionString);
            container.RegisterSingleton(new NotSimpleGameDBContext(optionsBuilder.Options));
        }
    }
}
