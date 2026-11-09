using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _35.Level26_TheOldRobot_Challenge
{
    public class NorthCommand : IRobotCommand
    {
        public  void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.Y++;
        }
    }
}