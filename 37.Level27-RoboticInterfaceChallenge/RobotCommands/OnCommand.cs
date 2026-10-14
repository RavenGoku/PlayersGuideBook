using System;
using System.Collections.Generic;
using System.Text;
using _35.Level26_TheOldRobot_Challenge;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class OnCommand : IRobotCommand
    {
        public  void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}