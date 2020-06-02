using System;
using System.Numerics;

namespace NotSimpleGame.Models
{
    public class Character : BaseModel<int>
    {
        public String Name { get; private set; }
        public Vector2 Position { get; private set; }
        public int MoveSpeed { get; private set; }
        public int JumpHeight { get; private set; }

        public Character(int id, String name,  int moveSpeed, int jumpHeight)
        {
            Id = id;
            Name = name;
            MoveSpeed = moveSpeed;
            JumpHeight = jumpHeight;
        }
    }
}
