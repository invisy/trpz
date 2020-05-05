﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Skins
{
    public abstract class Skin
    {
        abstract public CharacterType characterType { get; }
        public String Name { get; protected set;  }
        public float Price { get; protected set; }
        public String ModelPath { get; protected set; }

        public Skin(String name, float price, String modelPath)
        {
            Name = name;
            Price = price;
            ModelPath = modelPath;
        }

        internal abstract void ActivateAbility();
    }
}