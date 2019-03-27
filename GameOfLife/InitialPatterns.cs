using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    public static class InitialPatterns
    {
        public static Cell[,] Blinker()
        {
            return new Cell[3, 3] {
                { new Cell(false), new Cell(false), new Cell(false) },
                { new Cell(true), new Cell(true), new Cell(true) },
                { new Cell(false), new Cell(false), new Cell(false) }
            };
        }

        public static Cell[,] Toad()
        {
            return
            new Cell[5, 5] {
                { new Cell(false), new Cell(false),new Cell(false),new Cell(false) ,new Cell(false)},
                { new Cell(false), new Cell(false),new Cell(false),new Cell(false),new Cell(false) },
                 { new Cell(false), new Cell(true),new Cell(true),new Cell(true),new Cell(false) },
                  { new Cell(true), new Cell(true),new Cell(true),new Cell(false),new Cell(false) },
                   { new Cell(false), new Cell(false),new Cell(false),new Cell(false) ,new Cell(false)}
            };
        }

        public static Cell[,] Beacon()
        {
            return
            new Cell[5, 5] {
                { new Cell(false), new Cell(false),new Cell(false),new Cell(false) ,new Cell(false)},
                { new Cell(false), new Cell(true),new Cell(true),new Cell(false),new Cell(false) },
                 { new Cell(false), new Cell(true),new Cell(true),new Cell(false),new Cell(false) },
                  { new Cell(false), new Cell(false),new Cell(false),new Cell(true),new Cell(true) },
                   { new Cell(false), new Cell(false),new Cell(false),new Cell(true) ,new Cell(true)}
            };
        }

        public static Cell[,] LetterH()
        {
            return
             new Cell[5, 5] {
                { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(false), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                 { new Cell(false), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                  { new Cell(false), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                   { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)}
            };
        }
        public static Cell[,] LetterE()
        {
            return
             new Cell[5, 5] {
                { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(true) },
                 { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(true) },
                  { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(true) },
                   { new Cell(true), new Cell(false),new Cell(true),new Cell(false) ,new Cell(true)}
            };
        }

        public static Cell[,] LetterL()
        {
            return
             new Cell[5, 5] {
                 { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                 { new Cell(), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                  { new Cell(), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                   { new Cell(), new Cell(false),new Cell(false),new Cell(false) ,new Cell(true)}
            };
        }

        public static Cell[,] LetterO()
        {
            return
             new Cell[5, 5] {
               { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                 { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                  { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                   { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)}
            };
        }

        public static Cell[,] LetterW()
        {
            return
             new Cell[5, 5] {
               { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(false), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                 { new Cell(true), new Cell(true),new Cell(true),new Cell(true),new Cell(true) },
                  { new Cell(false), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                   { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)}
            };
        }

        public static Cell[,] LetterR()
        {
            return
             new Cell[5, 5] {
               { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                 { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                  { new Cell(true), new Cell(false),new Cell(true),new Cell(false),new Cell(false) },
                   { new Cell(false), new Cell(true),new Cell(false),new Cell(true) ,new Cell(true)}
            };
        }
        public static Cell[,] LetterD()
        {
            return
             new Cell[5, 5] {
                { new Cell(true), new Cell(true),new Cell(true),new Cell(true) ,new Cell(true)},
                { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                 { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                  { new Cell(true), new Cell(false),new Cell(false),new Cell(false),new Cell(true) },
                   { new Cell(false), new Cell(true),new Cell(true),new Cell(true) ,new Cell(false)}
            };
        }

        public static List<Cell[,]> HelloWorld()
        {
            var helloWorldList = new List<Cell[,]>();
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            helloWorldList.Add(LetterO());
            return helloWorldList;
        }

        public static List<Cell[,]> H()
        {
            var helloWorldList = new List<Cell[,]>();
            helloWorldList.Add(LetterH());
            return helloWorldList;
        }
    }
}
