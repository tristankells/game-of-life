using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTest
{
    [TestClass]
    public class CheckCellStatusTest
    {
        [TestMethod]
        public void CellIsAliveAndHasTwoNeighbours()
        {
            bool isAlive = true;
            int livingNeighbours = 2;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), true);
        }
        [TestMethod]
        public void CellIsAliveAndHasThreeNeighbours()
        {
            bool isAlive = true;
            int livingNeighbours = 3;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), true);
        }
        [TestMethod]
        public void CellIsAliveAndHasFourNeighbours()
        {
            bool isAlive = true;
            int livingNeighbours = 4;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), false);
        }
        [TestMethod]
        public void CellIsAliveAndHasEightNeighbours()
        {
            bool isAlive = true;
            int livingNeighbours = 8;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), false);
        }
        [TestMethod]
        public void CellIsAliveAndHasZeroNeighbours()
        {
            bool isAlive = true;
            int livingNeighbours = 0;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), false);
        }
        [TestMethod]
        public void CellIsDeadAndHasZeroNeighbours()
        {
            bool isAlive = false;
            int livingNeighbours = 0;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), false);
        }
        [TestMethod]
        public void CellIsDeadAndHasThreeNeighbours()
        {
            bool isAlive = false;
            int livingNeighbours = 3;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), true);
        }
        [TestMethod]
        public void CellIsDeadAndHasFourNeighbours()
        {
            bool isAlive = false;
            int livingNeighbours = 4;
            Assert.AreEqual(Board.CheckCellStatus(isAlive, livingNeighbours), false);
        }
    }
}
