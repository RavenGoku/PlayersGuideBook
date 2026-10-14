using System;
using System.Collections.Generic;
using System.Text;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class OffCommand : IRobotCommand
    {
        public  void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}