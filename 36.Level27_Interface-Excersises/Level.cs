using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _36.Level27_Interface_Excersises
{
    internal class Level
    {
        public int Width { get; }
        public int Height { get; }

        public TerrainType GetTerrainTypeAt(int row, int column)
        {
            /*  ----------------- */
            return TerrainType.Desert;
        }
    }
}