using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSimpleGame.Entities
{
    public class WeaponEntity : BaseEntity
    {
        public String name { get; set; }
        public float distance { get; set; }
        public float damage { get; set; }
        public float price { get; set; }
        public String modelPath { get; set; }
        public String character { get; set; }
    }
}
