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
            Random random = new Random(Environment.TickCount);

            for (int y = 0; y < 8; y++)
            {
                List<string> row = new List<string>();    
                for (int x = 0; x < 8; x++)
                {
                    int value = random.Next(0, 1000);
                    row.Add((value <= 200) ? "bomb" : "empty");
                }
                grid.Add(row);
            }
            return grid;
        }
    }
}
