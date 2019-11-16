using System;

namespace Board
{
    public class SmallBoard
    {
        private char[,] grid = new char[3, 3];

        public SmallBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = ' ';
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("     |     |     ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"  {this.grid[i, j]}  ");
                    if (j < 2) Console.Write("|");
                }

                if (i < 2)
                {
                    Console.WriteLine("\n_____|_____|_____");
                }
                else
                {
                    Console.WriteLine("\n     |     |     ");
                }
            }
        }
    }

    /*
    class SuperBoard
    {

    }
    */
}