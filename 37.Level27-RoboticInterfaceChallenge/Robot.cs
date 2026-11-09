using System;
using System.Collections.Generic;
using System.Text;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }

        public RobotCommand?[] Commands { get; } = new RobotCommand?[3];

        public void Run()
        {
            foreach (RobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
}