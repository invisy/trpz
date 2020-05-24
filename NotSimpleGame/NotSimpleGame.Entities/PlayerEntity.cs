﻿using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Entities.Enums;

namespace NotSimpleGame.Entities
{
    public class PlayerEntity : BaseEntity<int>
    {
        public uint Money { get; set; }
        public int CurrentSkinId { get; set; }
        public int CurrentWeaponId { get; set; }
        public SkinEntity Skin { get; set; }
        public WeaponEntity Weapon { get; set; }
        public CharacterType Character { get; set; }
    }
}
