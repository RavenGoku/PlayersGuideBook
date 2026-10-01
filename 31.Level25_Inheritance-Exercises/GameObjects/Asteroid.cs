using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace _31.Level25_Inheritance_Exercises
{
    internal class Asteroid : GameObject
    {
        //ctor parameterless
        public Asteroid() : this(0, 0, 0, 0)
        {

        }
        //ctor with parameters
        public Asteroid(float positionX, float positionY, float velocityX, float velocityY) : base(positionX, positionY,
            velocityX, velocityY)
        {
            RotationAngle = -1;
        }
        public float Size { get; }
        public float RotationAngle { get; }
    }
}
