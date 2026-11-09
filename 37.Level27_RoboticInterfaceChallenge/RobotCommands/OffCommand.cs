using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticInterfaceChallenge

{
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}