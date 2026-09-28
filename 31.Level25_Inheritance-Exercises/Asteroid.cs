using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _31.Level25_Inheritance_Exercises
{
    internal class Asteroid : GameObject
    {
        //ctor
        public Asteroid()
        {
            RotationAngle = -1;
        }
        
        public float Size { get; }
        public float RotationAngle { get; }
    }
}
