using System;
using System.Collections.Generic;
using System.Text;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X++;
        }
    }
}