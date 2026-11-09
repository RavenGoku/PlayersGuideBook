using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticInterfaceChallenge
{
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.Y--;
        }
    }
}