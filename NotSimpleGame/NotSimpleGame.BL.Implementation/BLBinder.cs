using NotSimpleGame.BL.Abstraction;
using NotSimpleGame.BL.Abstraction.Mappers;
using NotSimpleGame.BL.Implementation.Mappers;
using NotSimpleGame.BL.Implementation.Services;
using NotSimpleGame.Entities;
using NotSimpleGame.Models;
using NotSimpleGame.Utils;


namespace NotSimpleGame.BL.Implementation
{
    public static class BLBinder
    {
        public static void BindBL(this IIoCContainer container)
        {
            container.RegisterSingleton<IPlayerManager, PlayerManagerService>();
            container.Register<IMapper<CharacterEntity, Character>, CharactersMapper>();
            container.Register<IMapper<SkinEntity, Skin>, SkinsMapper>();
            container.Register<IMapper<WeaponEntity, Weapon>, WeaponsMapper>();
            container.Register<IMapper<PlayerEntity, Player>, PlayerMapper>();
        }
    }
}
