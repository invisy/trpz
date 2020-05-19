using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

using NotSimpleGame.DL.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class PlayerRepository : GenericRepository<PlayerEntity>, IPlayerRepository
    {
        public PlayerRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {
        }

        public override void Update(PlayerEntity entity)
        {
            PlayerEntity findEntity = this.Get(entity.Id);
            findEntity.Money = entity.Money;
            findEntity.Character = entity.Character;
            findEntity.CurrentSkinId = entity.Skin.Id;
            findEntity.CurrentWeaponId = entity.Weapon.Id;
        }

        public override PlayerEntity Get(int id)
        {
            return _dbSet.Include(e => e.Skin).Include(e => e.Weapon).FirstOrDefault(entity => entity.Id == id);
        }
    }
}
