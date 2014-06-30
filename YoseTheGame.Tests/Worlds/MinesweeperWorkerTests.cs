using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Worlds.Minesweeper;

namespace YoseTheGame.Tests.Worlds
{
    [TestClass]
    public class MinesweeperWorkerTests
    {
        [TestMethod]
        public void ReturnsListOfListOfStrings()
        {
            object response = MinesweeperWorker.GetRandomGrid();
            Assert.AreSame(response.GetType(), typeof(List<List<string>>));
        }

        [TestMethod]
        public void ReturnsValidData()
        {
            bool result = true;
            List<List<string>> response = MinesweeperWorker.GetRandomGrid();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((response[i][j] != "bomb") && (response[i][j] != "empty"))
                    {
                        result = false;
                        break;
                    }
                }
            }
            Assert.IsTrue(result);
        }
    }
}
