using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TheGameOfLifeNET;
using TheGameOfLifeNET.TheGameOfLifeNET;

namespace TheGameOfLifeShow
{
    public class GameOfLiveConsole
    {
        private Board board = new Board();

        public void ShowTask()
        {
            var task = new Task(() =>
            {
                for (;;)
                {
                    Console.Clear();
                    Show();
                    Thread.Sleep(1000);
                    board.Next();
                }

            });

            task.Start();
        }


        public void Show()
        {
            int[,] showTable = new int[20, 20];

            foreach (var item in board.boardList)
            {
                showTable[item.X, item.Y] = 1;
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (showTable[i, j] == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        public GameOfLiveConsole()
        {
            board.boardList.Add(new Point(1, 0));
            board.boardList.Add(new Point(1, 1));
            board.boardList.Add(new Point(1, 2));


            //board.boardList.Add(new Point(1, 2));
            //board.boardList.Add(new Point(2, 2));
            //board.boardList.Add(new Point(2, 3));
            //board.boardList.Add(new Point(3, 2));
            //board.boardList.Add(new Point(3, 3));
            //board.boardList.Add(new Point(4, 3));


            ShowTask();


            for (;;)
            {

            }

        }
    }
}
