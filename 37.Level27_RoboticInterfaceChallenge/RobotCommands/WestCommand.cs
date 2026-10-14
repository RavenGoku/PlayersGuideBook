using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticInterfaceChallenge
{
    internal class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X--;
        }
    }
}