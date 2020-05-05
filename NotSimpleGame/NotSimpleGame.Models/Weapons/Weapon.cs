﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.Characters;

namespace NotSimpleGame.Models.Weapons
{
    public abstract class Weapon
    {
        abstract public CharacterType characterType { get; }
        public String Name { get; protected set; }
        public float Distance { get; protected set; }
        public float Damage { get; protected set; }
        public float Price { get; protected set; }
        public String ModelPath { get; protected set; }

        public Weapon(String name, float distance, float damage, float price, String modelPath)
        {
            Name = name;
            Distance = distance;
            Damage = damage;
            Price = price;
            ModelPath = modelPath;
        }
        internal abstract void Shoot();
    }
}