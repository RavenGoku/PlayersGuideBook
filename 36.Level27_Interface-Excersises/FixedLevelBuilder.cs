using System;
using System.Collections.Generic;
using System.Text;

namespace _36.Level27_Interface_Excersises
{
    internal class FixedLevelBuilder : ILevelBuilder
    {
        public Level BuildLevel(int levelNumber)
        {
            Level level = new Level();
            Console.WriteLine($"Building level {levelNumber} using FixedLevelBuilder...");
            return level;
        }

        public string LvlName { get; set; }
    }
}