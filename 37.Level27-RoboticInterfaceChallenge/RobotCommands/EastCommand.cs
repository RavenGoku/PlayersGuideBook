using _37.Level27_RoboticInterfaceChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X++;
        }
    }
}