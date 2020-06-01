using NotSimpleGame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DL.Implementation;
using NotSimpleGame.BL.Abstraction;
using NotSimpleGame.BL.Implementation.Services;
using NotSimpleGame.BL.Abstraction.Mappers;
using NotSimpleGame.BL.Implementation.Mappers;

using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;


namespace NotSimpleGame.BL.Implementation
{
    public static class BLBinder
    {
        public static void BindBL(this IIoCContainer container)
        {
            container.RegisterSingleton<IPlayerManager, PlayerManagerService>();
            container.Register<IMapper<SkinEntity, Skin>, SkinsMapper>();
            container.Register<IMapper<WeaponEntity, Weapon>, WeaponsMapper>();
            container.Register<IMapper<PlayerEntity, Player>, PlayerMapper>();
        }
    }
}
