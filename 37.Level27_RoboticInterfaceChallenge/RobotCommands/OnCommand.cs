using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticInterfaceChallenge
{
    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}