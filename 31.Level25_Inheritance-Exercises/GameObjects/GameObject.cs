using System;
using System.Collections.Generic;
using System.Text;

namespace _31.Level25_Inheritance_Exercises
{
    internal class GameObject
    {
        public GameObject() : this (0,0,0,0)
        {

        }
        //ctor
        public GameObject(float posX, float posY, float velocityX, float velocityY)
        {
            PositionX = posX;
            PositionY = posY;
            VelocityX = velocityX;
            VelocityY = velocityY;
        }
        public float PositionX { get; protected set; }
        public float PositionY { get; protected set; }
        public float VelocityX { get; protected set; }
        public float VelocityY { get; protected set; }
        public void Update()
        {
            PositionX += VelocityX;
            PositionY += VelocityY;
        }
    }
}
