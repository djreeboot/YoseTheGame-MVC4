using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoseTheGame.Worlds.Minesweeper
{
    public class MinesweeperWorker
    {
        public static List<List<string>> GetRandomGrid()
        {
            List<List<string>> grid = new List<List<string>>();
            for (int y = 0; y < 8; y++)
            {
                List<string> row = new List<string>();
                Random random = new Random(DateTime.Now.Millisecond);
                for (int x = 0; x < 8; x++)
                {
                    row.Add(random.Next(0, 10) <= 2 ? "bomb" : "empty");
                }
                grid.Add(row);
            }
            return grid;
        }
    }
}
