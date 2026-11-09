using System;
using System.Collections.Generic;
using System.Text;

namespace _35.Level26_TheOldRobot_Challenge
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