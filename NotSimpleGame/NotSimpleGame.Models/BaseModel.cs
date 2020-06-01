using System;
using System.Collections.Generic;
using System.Text;

namespace NotSimpleGame.Models
{
    public abstract class BaseModel<TKey>
    {
        public TKey Id { get; set; }
    }
}
