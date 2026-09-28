using System;
using System.Collections.Generic;
using System.Text;

namespace _31.Level25_Inheritance_Exercises
{
    internal class GameObject
    {
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public void Update()
        {
            PositionX += VelocityX;
            PositionY += VelocityY;
        }
    }
}
