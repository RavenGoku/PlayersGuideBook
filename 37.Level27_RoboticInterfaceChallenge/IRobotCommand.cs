using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticInterfaceChallenge
{
    public interface IRobotCommand
    {
        void Run(Robot robot);
    }
}