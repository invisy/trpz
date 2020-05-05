using NotSimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Entities
{
    public class PlayerEntity : BaseEntity
    {
        public int money { get; set; }
        public SkinEntity Skin { get; set; }
        public WeaponEntity weapon { get; set; }
    }
}
