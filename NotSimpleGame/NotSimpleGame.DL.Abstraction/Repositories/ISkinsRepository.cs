﻿using System;
using System.Collections.Generic;
using System.Text;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Abstraction.Repositories
{
    public interface ISkinsRepository : IRepository<SkinEntity, int>
    {
        IEnumerable<SkinEntity> FindAllByCharacter(int character);
    }
}
