﻿using UnityFoundation.Code.Grid;

namespace GameAssets.BasicMazeGenerator
{
    public class StraightCrawler : IGridCrawler
    {
        private readonly int line;

        public StraightCrawler(int line)
        {
            this.line = line;
        }

        public void Craw(IGridXZ<bool> grid, bool value = false)
        {
            foreach(var gridPos in grid.GridArray)
            {
                if(gridPos.Z == line)
                    gridPos.Value = value;
            }
        }
    }
}