using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;


namespace GameOfLifeTest
{
    [TestClass]
    public class GetLivingNeighboursTest
    {
        [TestMethod]
        public void CellHasZeroAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 0);
        }

        [TestMethod]
        public void CellHasOneAliveNeighbour()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 1);
        }

        [TestMethod]
        public void CellHasTwoAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(false), new Cell(false), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 2);
        }

        [TestMethod]
        public void CellHasThreeAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(false), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 3);
        }

        [TestMethod]
        public void CellHasFourAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(true), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 4);
        }

        [TestMethod]
        public void CellHasFiveAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(true), new Cell(false) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 5);
        }

        [TestMethod]
        public void CellHasSixAliveNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 6);
        }

        [TestMethod]
        public void CellHasAliveSevenNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(false), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 7);
        }

        [TestMethod]
        public void CellHasAliveEightNeighbours()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(1, 1), 8);
        }

        [TestMethod]
        public void CellIsAtTopLeftBoundary()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(0, 0), 2);
        }

        [TestMethod]
        public void CellIsAtTopRightBoundary()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(0, 2), 2);
        }

        [TestMethod]
        public void CellIsAtBottomLeftBoundary()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(2, 0), 2);
        }

        [TestMethod]
        public void CellIsAtBottomMidBoundary()
        {
            Board b = new Board(new Cell[3, 3] {
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(true), new Cell(false), new Cell(true) },
                { new Cell(true), new Cell(true), new Cell(true) }
            });

            Assert.AreEqual(b.GetLivingNeighbors(2, 1), 4);
        }
    }
}
