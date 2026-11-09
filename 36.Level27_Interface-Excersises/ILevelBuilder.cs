using System;
using System.Collections.Generic;
using System.Text;

namespace _36.Level27_Interface_Excersises
{
    internal interface ILevelBuilder
    {
        public abstract Level BuildLevel(int levelNumber);
        string LvlName { get => "Name" ; }
    }
    }
}