using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.Y++;
        }
    }
}